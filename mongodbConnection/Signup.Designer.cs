
using MongoDB.Driver;
using System.Configuration;

namespace mongodbConnection
{
    partial class Signup
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
            label3 = new Label();
            registerbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtfname = new TextBox();
            txtlname = new TextBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtage = new TextBox();
            txtaddress = new TextBox();
            backtologinlink = new LinkLabel();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 29);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 9;
            label3.Text = "SignUp Page";
            label3.Click += label3_Click;
            // 
            // registerbtn
            // 
            registerbtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbtn.Location = new Point(135, 292);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(84, 26);
            registerbtn.TabIndex = 6;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 98);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 11;
            label1.Text = "FirstName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 128);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 11;
            label2.Text = "LastName :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 158);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 11;
            label4.Text = "Age :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(74, 188);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 11;
            label5.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 218);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 11;
            label6.Text = "Username :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(65, 248);
            label7.Name = "label7";
            label7.Size = new Size(73, 17);
            label7.TabIndex = 11;
            label7.Text = "Password :";
            // 
            // txtfname
            // 
            txtfname.Location = new Point(153, 95);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(139, 23);
            txtfname.TabIndex = 0;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(153, 125);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(139, 23);
            txtlname.TabIndex = 1;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(153, 216);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(139, 23);
            txtusername.TabIndex = 4;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(153, 246);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(139, 23);
            txtpassword.TabIndex = 5;
            // 
            // txtage
            // 
            txtage.Location = new Point(153, 155);
            txtage.Name = "txtage";
            txtage.Size = new Size(139, 23);
            txtage.TabIndex = 2;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(153, 185);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(139, 23);
            txtaddress.TabIndex = 3;
            // 
            // backtologinlink
            // 
            backtologinlink.AutoSize = true;
            backtologinlink.Location = new Point(12, 362);
            backtologinlink.Name = "backtologinlink";
            backtologinlink.Size = new Size(79, 15);
            backtologinlink.TabIndex = 7;
            backtologinlink.TabStop = true;
            backtologinlink.Text = "Back to Login";
            backtologinlink.LinkClicked += backtologinlink_LinkClicked;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 386);
            Controls.Add(backtologinlink);
            Controls.Add(txtaddress);
            Controls.Add(txtage);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registerbtn);
            Controls.Add(label3);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Signup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            var connnectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var dbname = MongoUrl.Create(connnectionString).DatabaseName;
            var mongoClient = new MongoClient(connnectionString);
            var database = mongoClient.GetDatabase(dbname);
            UserCollection = database.GetCollection<login>("login");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Label label3;
        private Button registerbtn;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtfname;
        private TextBox txtlname;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtage;
        private TextBox txtaddress;
        private LinkLabel backtologinlink;
    }
}