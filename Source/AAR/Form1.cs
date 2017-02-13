using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AAR
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_Auth_CheckedChanged(object sender, EventArgs e)
        {
            label_Username.Visible = checkBox_Auth.Checked; textBox_Username.Visible = checkBox_Auth.Checked;
            label_Password.Visible = checkBox_Auth.Checked; textBox_Password.Visible = checkBox_Auth.Checked;
        }

        private bool ElementDisplayed(IWebDriver _driver, By by, int timeout)
        {
            try
            {
                var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(timeout));
                var myElement = wait.Until(x => x.FindElement(by));
                return myElement.Displayed;
            }
            catch
            {
                return false;
            }
        }

        private int getPid(IEnumerable<int> lastPids)
        {
            IEnumerable<int> newPids = Process.GetProcessesByName("chrome").Select(p => p.Id);
            IEnumerable<int> pids = newPids.Except(lastPids);

            return newPids.FirstOrDefault();
        }
        private void startProcess(string url, int waiting_time, string type=null, string address=null, string username=null, string password=null)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            if(type != null)
            {
                Proxy proxy = new Proxy();

                if(type == "http")
                    proxy.HttpProxy = address;
                else if(type == "socks" && username != null && password != null)
                {
                    proxy.SocksProxy = address;
                    proxy.SocksUserName = username;
                    proxy.SocksPassword = password;
                }

                chromeOptions.Proxy = proxy;
            }

            IEnumerable<int> pids = Process.GetProcessesByName("chrome").Select(p => p.Id);

            IWebDriver _driver = new ChromeDriver(driverService, chromeOptions);
            _driver.Navigate().GoToUrl(url);

            int pid = getPid(pids);

            while (true)
            {
                if (ElementDisplayed(_driver, By.CssSelector(".message.message-1.hidden"), 20))
                {
                    System.Threading.Thread.Sleep(waiting_time * 1000);

                    if (_driver.FindElements(By.ClassName("size-chart")).Count > 0)
                        break;

                    //get chrome process and show it so we can send the keys
                    Process process = Process.GetProcessById(pid).Parent();
                    SetForegroundWindow(process.MainWindowHandle);
                    SetWindowPos(process.MainWindowHandle, 0, 0, 0, 0, 0, 0x0002 | 0x0001 | 0x0040);
                    System.Threading.Thread.Sleep(1000);
                    //only way to clear cache programmatically in selenium
                    SendKeys.SendWait("^+{DEL}"); // '^' = CTRL - '+' = SHIFT - '{DEL}' = DELETE


                    //wait until the new tab is visible
                    var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
                    wait.Until(x => x.WindowHandles.Count > 1);

                    //switch to new tab
                    _driver.SwitchTo().Window(_driver.WindowHandles[1]);
                    IWebElement element = _driver.FindElement(By.Name("settings"));
                    _driver.SwitchTo().Frame(element);

                    //save cookies in case we pass the splash page during the process
                    System.Collections.ObjectModel.ReadOnlyCollection<Cookie> cookies = _driver.Manage().Cookies.AllCookies;

                    //clear cache and cookies
                    if (ElementDisplayed(_driver, By.Id("clear-browser-data-commit"), 30))
                        _driver.FindElement(By.Id("clear-browser-data-commit")).Click();

                    //wait until cache is cleared
                    wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("clear-browser-data-commit")));

                    //switch to main tab
                    _driver.Close();
                    _driver.SwitchTo().Window(_driver.WindowHandles[0]);

                    //set cookies in case we reached the product page during the process
                    if (_driver.FindElements(By.ClassName("size-chart")).Count > 0)
                    {
                        foreach (Cookie cookie in cookies)
                            _driver.Manage().Cookies.AddCookie(cookie);

                        break;
                    }

                    //refresh and repeat...
                    _driver.Navigate().Refresh();
                }
                else if (_driver.FindElements(By.ClassName("size-chart")).Count > 0)
                    break;
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Url.Text))
            {
                MessageBox.Show("You must enter a url!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(comboBox_Type.SelectedIndex == -1 && !String.IsNullOrEmpty(textBox_Address.Text))
            {
                MessageBox.Show("You select a proxy type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(numericUpDown_Wait.Value < 3)
            {
                MessageBox.Show("Min. waiting time is 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if(!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\chromedriver.exe"))
            {
                MessageBox.Show("chromedriver.exe not found in application directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int waiting_time = Convert.ToInt32(numericUpDown_Wait.Value);
            string type = comboBox_Type.SelectedItem.ToString();

            if (checkBox_Auth.Checked)
                Task.Run(() => startProcess(textBox_Url.Text, waiting_time, type, textBox_Address.Text, textBox_Username.Text, textBox_Password.Text));
            else if (!String.IsNullOrEmpty(textBox_Address.Text))
                Task.Run(() => startProcess(textBox_Url.Text, waiting_time, type, textBox_Address.Text));
            else
                Task.Run(() => startProcess(textBox_Url.Text, waiting_time));
        }
    }
}
