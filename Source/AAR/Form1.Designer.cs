namespace AAR
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Url = new System.Windows.Forms.Label();
            this.textBox_Url = new System.Windows.Forms.TextBox();
            this.label_Proxy = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.checkBox_Auth = new System.Windows.Forms.CheckBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Wait = new System.Windows.Forms.Label();
            this.numericUpDown_Wait = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Wait)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Url
            // 
            this.label_Url.AutoSize = true;
            this.label_Url.Location = new System.Drawing.Point(144, 10);
            this.label_Url.Name = "label_Url";
            this.label_Url.Size = new System.Drawing.Size(59, 13);
            this.label_Url.TabIndex = 0;
            this.label_Url.Text = "Splash url :";
            // 
            // textBox_Url
            // 
            this.textBox_Url.Location = new System.Drawing.Point(32, 28);
            this.textBox_Url.Name = "textBox_Url";
            this.textBox_Url.Size = new System.Drawing.Size(280, 20);
            this.textBox_Url.TabIndex = 1;
            // 
            // label_Proxy
            // 
            this.label_Proxy.AutoSize = true;
            this.label_Proxy.Location = new System.Drawing.Point(199, 62);
            this.label_Proxy.Name = "label_Proxy";
            this.label_Proxy.Size = new System.Drawing.Size(239, 13);
            this.label_Proxy.TabIndex = 2;
            this.label_Proxy.Text = "Proxy (leave blank if you don\'t want to use one) : ";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(197, 105);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(246, 20);
            this.textBox_Address.TabIndex = 3;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "http",
            "socks"});
            this.comboBox_Type.Location = new System.Drawing.Point(32, 105);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(88, 21);
            this.comboBox_Type.TabIndex = 4;
            // 
            // checkBox_Auth
            // 
            this.checkBox_Auth.AutoSize = true;
            this.checkBox_Auth.Location = new System.Drawing.Point(512, 107);
            this.checkBox_Auth.Name = "checkBox_Auth";
            this.checkBox_Auth.Size = new System.Drawing.Size(94, 17);
            this.checkBox_Auth.TabIndex = 5;
            this.checkBox_Auth.Text = "Authentication";
            this.checkBox_Auth.UseVisualStyleBackColor = true;
            this.checkBox_Auth.CheckedChanged += new System.EventHandler(this.checkBox_Auth_CheckedChanged);
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(61, 89);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(31, 13);
            this.label_Type.TabIndex = 6;
            this.label_Type.Text = "Type";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(260, 89);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(160, 13);
            this.label_Address.TabIndex = 7;
            this.label_Address.Text = "Address (ip:port without http:// !)";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(147, 147);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(131, 20);
            this.textBox_Username.TabIndex = 8;
            this.textBox_Username.Visible = false;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(346, 147);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(136, 20);
            this.textBox_Password.TabIndex = 9;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.Visible = false;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(184, 132);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(55, 13);
            this.label_Username.TabIndex = 10;
            this.label_Username.Text = "Username";
            this.label_Username.Visible = false;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(383, 132);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 11;
            this.label_Password.Text = "Password";
            this.label_Password.Visible = false;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(18, 183);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(594, 23);
            this.button_Start.TabIndex = 12;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Wait
            // 
            this.label_Wait.AutoSize = true;
            this.label_Wait.Location = new System.Drawing.Point(405, 0);
            this.label_Wait.Name = "label_Wait";
            this.label_Wait.Size = new System.Drawing.Size(215, 26);
            this.label_Wait.TabIndex = 13;
            this.label_Wait.Text = "Time to wait before clearing cache/cookies \r\n              and refreshing(in seco" +
    "nds) :";
            // 
            // numericUpDown_Wait
            // 
            this.numericUpDown_Wait.Location = new System.Drawing.Point(475, 28);
            this.numericUpDown_Wait.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown_Wait.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_Wait.Name = "numericUpDown_Wait";
            this.numericUpDown_Wait.ReadOnly = true;
            this.numericUpDown_Wait.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown_Wait.TabIndex = 14;
            this.numericUpDown_Wait.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 209);
            this.Controls.Add(this.numericUpDown_Wait);
            this.Controls.Add(this.label_Wait);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.checkBox_Auth);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_Proxy);
            this.Controls.Add(this.textBox_Url);
            this.Controls.Add(this.label_Url);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AAR";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Wait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Url;
        private System.Windows.Forms.TextBox textBox_Url;
        private System.Windows.Forms.Label label_Proxy;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.CheckBox checkBox_Auth;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Wait;
        private System.Windows.Forms.NumericUpDown numericUpDown_Wait;
    }
}

