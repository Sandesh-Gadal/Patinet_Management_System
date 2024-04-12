namespace mongodbConnection
{
    partial class loginpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            register = new Button();
            linkLabel1 = new LinkLabel();
            adminloginbtn = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.Location = new Point(207, 243);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(111, 30);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "Login As User";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 149);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 1;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 194);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(169, 148);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(100, 23);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(169, 188);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(100, 23);
            txtpassword.TabIndex = 4;
            // 
            // register
            // 
            register.Location = new Point(306, 379);
            register.Name = "register";
            register.Size = new Size(75, 23);
            register.TabIndex = 5;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(120, 303);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No Account? Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // adminloginbtn
            // 
            adminloginbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminloginbtn.Location = new Point(67, 243);
            adminloginbtn.Name = "adminloginbtn";
            adminloginbtn.Size = new Size(125, 30);
            adminloginbtn.TabIndex = 7;
            adminloginbtn.Text = "Login As Admin";
            adminloginbtn.UseVisualStyleBackColor = true;
            adminloginbtn.Click += adminloginbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(120, 72);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 8;
            label3.Text = "Login Page";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(36, 24);
            label4.Name = "label4";
            label4.Size = new Size(342, 30);
            label4.TabIndex = 9;
            label4.Text = "Patient Management System";
            // 
            // loginpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(407, 404);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(adminloginbtn);
            Controls.Add(linkLabel1);
            Controls.Add(register);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbtn);
            Name = "loginpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginpage";
            Load += loginpage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button register;
        private LinkLabel linkLabel1;
        private Button adminloginbtn;
        private Label label3;
        private Label label4;
    }
}