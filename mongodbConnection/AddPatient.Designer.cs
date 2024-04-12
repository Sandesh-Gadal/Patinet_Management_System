namespace mongodbConnection
{
    partial class AddPatient
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
            Addgroupbox = new GroupBox();
            addbtn = new Button();
            bgroupcmbbox = new ComboBox();
            gendercmbbox = new ComboBox();
            txtdisease = new TextBox();
            txtphoneno = new TextBox();
            txtfullname = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            txtage = new TextBox();
            label6 = new Label();
            label3 = new Label();
            txtaddress = new TextBox();
            txtpatient_id = new TextBox();
            label5 = new Label();
            label1 = new Label();
            Addgroupbox.SuspendLayout();
            SuspendLayout();
            // 
            // Addgroupbox
            // 
            Addgroupbox.Controls.Add(addbtn);
            Addgroupbox.Controls.Add(bgroupcmbbox);
            Addgroupbox.Controls.Add(gendercmbbox);
            Addgroupbox.Controls.Add(txtdisease);
            Addgroupbox.Controls.Add(txtphoneno);
            Addgroupbox.Controls.Add(txtfullname);
            Addgroupbox.Controls.Add(label8);
            Addgroupbox.Controls.Add(label4);
            Addgroupbox.Controls.Add(label7);
            Addgroupbox.Controls.Add(label2);
            Addgroupbox.Controls.Add(txtage);
            Addgroupbox.Controls.Add(label6);
            Addgroupbox.Controls.Add(label3);
            Addgroupbox.Controls.Add(txtaddress);
            Addgroupbox.Controls.Add(txtpatient_id);
            Addgroupbox.Controls.Add(label5);
            Addgroupbox.Controls.Add(label1);
            Addgroupbox.FlatStyle = FlatStyle.Flat;
            Addgroupbox.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addgroupbox.Location = new Point(15, 20);
            Addgroupbox.Name = "Addgroupbox";
            Addgroupbox.Size = new Size(598, 415);
            Addgroupbox.TabIndex = 0;
            Addgroupbox.TabStop = false;
            Addgroupbox.Text = "Add New Patients";
            Addgroupbox.Enter += Addgroupbox_Enter;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(214, 343);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(117, 33);
            addbtn.TabIndex = 3;
            addbtn.Text = "Add Patient";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // bgroupcmbbox
            // 
            bgroupcmbbox.FormattingEnabled = true;
            bgroupcmbbox.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            bgroupcmbbox.Location = new Point(420, 151);
            bgroupcmbbox.Name = "bgroupcmbbox";
            bgroupcmbbox.Size = new Size(159, 28);
            bgroupcmbbox.TabIndex = 2;
            // 
            // gendercmbbox
            // 
            gendercmbbox.FormattingEnabled = true;
            gendercmbbox.Items.AddRange(new object[] { "Select", "Male ", "Female", "Others" });
            gendercmbbox.Location = new Point(106, 201);
            gendercmbbox.Name = "gendercmbbox";
            gendercmbbox.Size = new Size(159, 28);
            gendercmbbox.TabIndex = 2;
            // 
            // txtdisease
            // 
            txtdisease.Location = new Point(420, 201);
            txtdisease.Name = "txtdisease";
            txtdisease.Size = new Size(159, 27);
            txtdisease.TabIndex = 1;
            // 
            // txtphoneno
            // 
            txtphoneno.Location = new Point(420, 107);
            txtphoneno.Name = "txtphoneno";
            txtphoneno.Size = new Size(159, 27);
            txtphoneno.TabIndex = 1;
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(106, 107);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(159, 27);
            txtfullname.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(344, 206);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 0;
            label8.Text = "Disease :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 206);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Gender :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(290, 112);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 0;
            label7.Text = "Phone Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Full Name :";
            // 
            // txtage
            // 
            txtage.Location = new Point(106, 154);
            txtage.Name = "txtage";
            txtage.Size = new Size(159, 27);
            txtage.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 159);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 0;
            label6.Text = "Blood Group :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 159);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 0;
            label3.Text = "Age :";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(420, 60);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(159, 27);
            txtaddress.TabIndex = 1;
            // 
            // txtpatient_id
            // 
            txtpatient_id.Location = new Point(106, 60);
            txtpatient_id.Name = "txtpatient_id";
            txtpatient_id.Size = new Size(159, 27);
            txtpatient_id.TabIndex = 1;
            txtpatient_id.TextChanged += txtpatient_id_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 65);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 0;
            label5.Text = "Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 67);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Patient_ID :";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 447);
            Controls.Add(Addgroupbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPatient";
            Text = "AddPatient";
            Load += AddPatient_Load;
            Addgroupbox.ResumeLayout(false);
            Addgroupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Addgroupbox;
        private TextBox txtfullname;
        private Label label4;
        private Label label2;
        private TextBox txtage;
        private Label label3;
        private TextBox txtpatient_id;
        private Label label1;
        private TextBox txtdisease;
        private TextBox txtphoneno;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtaddress;
        private Label label5;
        private ComboBox bgroupcmbbox;
        private ComboBox gendercmbbox;
        private Button addbtn;
    }
}