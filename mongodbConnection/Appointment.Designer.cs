namespace mongodbConnection
{
    partial class Appointment
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            logoutlabel = new LinkLabel();
            bookbtn = new Button();
            cmbdoctor = new ComboBox();
            cmbgender = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            txtdisease = new TextBox();
            txtage = new TextBox();
            txtpname = new TextBox();
            txtpid = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 0;
            label1.Text = "Appointment Form";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(logoutlabel);
            groupBox1.Controls.Add(bookbtn);
            groupBox1.Controls.Add(cmbdoctor);
            groupBox1.Controls.Add(cmbgender);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtdisease);
            groupBox1.Controls.Add(txtage);
            groupBox1.Controls.Add(txtpname);
            groupBox1.Controls.Add(txtpid);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(585, 351);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book your appointment";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // logoutlabel
            // 
            logoutlabel.AutoSize = true;
            logoutlabel.Location = new Point(6, 328);
            logoutlabel.Name = "logoutlabel";
            logoutlabel.Size = new Size(57, 20);
            logoutlabel.TabIndex = 6;
            logoutlabel.TabStop = true;
            logoutlabel.Text = "Log out";
            logoutlabel.LinkClicked += logoutlabel_LinkClicked;
            // 
            // bookbtn
            // 
            bookbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookbtn.Location = new Point(233, 284);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(122, 35);
            bookbtn.TabIndex = 5;
            bookbtn.Text = "Book";
            bookbtn.UseVisualStyleBackColor = true;
            bookbtn.Click += bookbtn_Click;
            // 
            // cmbdoctor
            // 
            cmbdoctor.FormattingEnabled = true;
            cmbdoctor.Items.AddRange(new object[] { "Choose your Doctor", "Dr.Subham gupta", "Dr.Sanduk ruit" });
            cmbdoctor.Location = new Point(142, 177);
            cmbdoctor.Name = "cmbdoctor";
            cmbdoctor.Size = new Size(146, 28);
            cmbdoctor.TabIndex = 4;
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Items.AddRange(new object[] { "Select one ", "Male", "Female", "Others" });
            cmbgender.Location = new Point(142, 130);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(146, 28);
            cmbgender.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(142, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 33);
            label3.Name = "label3";
            label3.Size = new Size(237, 20);
            label3.TabIndex = 2;
            label3.Text = "( If you are have Previous Checkup )";
            // 
            // txtdisease
            // 
            txtdisease.Location = new Point(407, 129);
            txtdisease.Name = "txtdisease";
            txtdisease.Size = new Size(166, 27);
            txtdisease.TabIndex = 1;
            // 
            // txtage
            // 
            txtage.Location = new Point(405, 83);
            txtage.Name = "txtage";
            txtage.Size = new Size(166, 27);
            txtage.TabIndex = 1;
            // 
            // txtpname
            // 
            txtpname.Location = new Point(142, 85);
            txtpname.Name = "txtpname";
            txtpname.Size = new Size(146, 27);
            txtpname.TabIndex = 1;
            // 
            // txtpid
            // 
            txtpid.Location = new Point(118, 30);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(109, 27);
            txtpid.TabIndex = 1;
            txtpid.TextChanged += txtpid_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 223);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 0;
            label9.Text = "Choose you Date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(75, 179);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 0;
            label8.Text = "Doctor :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(333, 134);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 0;
            label7.Text = "Disease :";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(72, 132);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 0;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 84);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 0;
            label5.Text = "Age :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 90);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 0;
            label4.Text = "Patient Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 33);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 0;
            label2.Text = "Patient_ID :";
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 408);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtpid;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtdisease;
        private TextBox txtage;
        private TextBox txtpname;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbdoctor;
        private ComboBox cmbgender;
        private Label label9;
        private Button bookbtn;
        private LinkLabel logoutlabel;
    }
}