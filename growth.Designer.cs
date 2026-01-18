namespace growth_c_sharp
{
    partial class growth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Home_label = new LinkLabel();
            Create_label = new LinkLabel();
            Updates_label = new LinkLabel();
            Connect_label = new LinkLabel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Login = new Label();
            Username = new Label();
            Password = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // Home_label
            // 
            Home_label.AutoSize = true;
            Home_label.Font = new Font("Georgia", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Home_label.ForeColor = Color.FromArgb(30, 30, 30);
            Home_label.LinkColor = Color.FromArgb(30, 30, 30);
            Home_label.Location = new Point(140, 272);
            Home_label.Name = "Home_label";
            Home_label.Size = new Size(95, 35);
            Home_label.TabIndex = 0;
            Home_label.TabStop = true;
            Home_label.Text = "Home";
            Home_label.UseWaitCursor = true;
            Home_label.VisitedLinkColor = Color.FromArgb(30, 30, 30);
            Home_label.LinkClicked += Home_label_LinkClicked;
            // 
            // Create_label
            // 
            Create_label.AutoSize = true;
            Create_label.Font = new Font("Georgia", 9F, FontStyle.Italic);
            Create_label.ForeColor = Color.FromArgb(30, 30, 30);
            Create_label.LinkColor = Color.FromArgb(30, 30, 30);
            Create_label.Location = new Point(636, 272);
            Create_label.Name = "Create_label";
            Create_label.Size = new Size(103, 35);
            Create_label.TabIndex = 1;
            Create_label.TabStop = true;
            Create_label.Text = "Create";
            Create_label.VisitedLinkColor = Color.FromArgb(30, 30, 30);
            Create_label.LinkClicked += Create_label_LinkClicked;
            // 
            // Updates_label
            // 
            Updates_label.AutoSize = true;
            Updates_label.Font = new Font("Georgia", 9F, FontStyle.Italic);
            Updates_label.ForeColor = Color.FromArgb(30, 30, 30);
            Updates_label.LinkColor = Color.FromArgb(30, 30, 30);
            Updates_label.Location = new Point(1207, 272);
            Updates_label.Name = "Updates_label";
            Updates_label.Size = new Size(126, 35);
            Updates_label.TabIndex = 2;
            Updates_label.TabStop = true;
            Updates_label.Text = "Updates";
            Updates_label.VisitedLinkColor = Color.FromArgb(30, 30, 30);
            Updates_label.LinkClicked += Updates_label_LinkClicked;
            // 
            // Connect_label
            // 
            Connect_label.AutoSize = true;
            Connect_label.Font = new Font("Georgia", 9F, FontStyle.Italic);
            Connect_label.ForeColor = Color.FromArgb(30, 30, 30);
            Connect_label.LinkColor = Color.FromArgb(30, 30, 30);
            Connect_label.Location = new Point(1748, 272);
            Connect_label.Name = "Connect_label";
            Connect_label.Size = new Size(124, 35);
            Connect_label.TabIndex = 3;
            Connect_label.TabStop = true;
            Connect_label.Text = "Connect";
            Connect_label.VisitedLinkColor = Color.FromArgb(30, 30, 30);
            Connect_label.LinkClicked += Connect_label_LinkClicked;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 5;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Georgia", 9F);
            Login.ForeColor = Color.FromArgb(30, 30, 30);
            Login.Location = new Point(91, 9);
            Login.Name = "Login";
            Login.Size = new Size(91, 35);
            Login.TabIndex = 6;
            Login.Text = "Login";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Georgia", 9F);
            Username.ForeColor = Color.FromArgb(30, 30, 30);
            Username.Location = new Point(-3, 53);
            Username.Name = "Username";
            Username.Size = new Size(78, 35);
            Username.TabIndex = 7;
            Username.Text = "User";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Georgia", 9F);
            Password.ForeColor = Color.FromArgb(30, 30, 30);
            Password.Location = new Point(0, 119);
            Password.Name = "Password";
            Password.Size = new Size(74, 35);
            Password.TabIndex = 8;
            Password.Text = "Pass";
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Georgia", 9F);
            LoginButton.ForeColor = Color.FromArgb(30, 30, 30);
            LoginButton.Location = new Point(123, 172);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(188, 58);
            LoginButton.TabIndex = 9;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // growth
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 228, 215);
            ClientSize = new Size(1990, 1160);
            Controls.Add(LoginButton);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Connect_label);
            Controls.Add(Updates_label);
            Controls.Add(Create_label);
            Controls.Add(Home_label);
            Name = "growth";
            Text = "Window";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private LinkLabel Home_label;
        private LinkLabel Create_label;
        private LinkLabel Updates_label;
        private LinkLabel Connect_label;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Login;
        private Label Username;
        private Label Password;
        private Button LoginButton;
    }
}
