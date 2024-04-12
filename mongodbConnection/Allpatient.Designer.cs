namespace mongodbConnection
{
    partial class Allpatient
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
            heading = new Label();
            groupBox1 = new GroupBox();
            patientdatagrid = new DataGridView();
            groupBox2 = new GroupBox();
            insidegrpbox = new GroupBox();
            txtPatientname = new TextBox();
            txtPatientId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            deletebtn = new Button();
            searchbtn = new Button();
            allshowbtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientdatagrid).BeginInit();
            groupBox2.SuspendLayout();
            insidegrpbox.SuspendLayout();
            SuspendLayout();
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading.Location = new Point(209, 9);
            heading.Name = "heading";
            heading.Size = new Size(206, 30);
            heading.TabIndex = 0;
            heading.Text = "All Patients Details";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(patientdatagrid);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Patients Detail Section";
            // 
            // patientdatagrid
            // 
            patientdatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientdatagrid.Location = new Point(6, 19);
            patientdatagrid.Name = "patientdatagrid";
            patientdatagrid.Size = new Size(587, 150);
            patientdatagrid.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(insidegrpbox);
            groupBox2.Controls.Add(deletebtn);
            groupBox2.Controls.Add(searchbtn);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(601, 155);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search And Delete Section";
            // 
            // insidegrpbox
            // 
            insidegrpbox.Controls.Add(txtPatientname);
            insidegrpbox.Controls.Add(txtPatientId);
            insidegrpbox.Controls.Add(label2);
            insidegrpbox.Controls.Add(label1);
            insidegrpbox.Location = new Point(20, 24);
            insidegrpbox.Name = "insidegrpbox";
            insidegrpbox.Size = new Size(302, 114);
            insidegrpbox.TabIndex = 1;
            insidegrpbox.TabStop = false;
            // 
            // txtPatientname
            // 
            txtPatientname.Location = new Point(144, 68);
            txtPatientname.Name = "txtPatientname";
            txtPatientname.Size = new Size(152, 25);
            txtPatientname.TabIndex = 1;
            // 
            // txtPatientId
            // 
            txtPatientId.Location = new Point(144, 28);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(152, 25);
            txtPatientId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 69);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Patient_Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Patient_ID :";
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(328, 93);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 0;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(328, 54);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 0;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // allshowbtn
            // 
            allshowbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allshowbtn.Location = new Point(461, 230);
            allshowbtn.Name = "allshowbtn";
            allshowbtn.Size = new Size(134, 23);
            allshowbtn.TabIndex = 0;
            allshowbtn.Text = "Show All Patients";
            allshowbtn.UseVisualStyleBackColor = true;
            allshowbtn.Click += allshowbtn_Click;
            // 
            // Allpatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 447);
            Controls.Add(allshowbtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(heading);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Allpatient";
            Text = "Allpatient";
            Load += Allpatient_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)patientdatagrid).EndInit();
            groupBox2.ResumeLayout(false);
            insidegrpbox.ResumeLayout(false);
            insidegrpbox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading;
        private GroupBox groupBox1;
        private DataGridView patientdatagrid;
        private GroupBox groupBox2;
        private Button deletebtn;
        private Button searchbtn;
        private Button allshowbtn;
        private GroupBox insidegrpbox;
        private TextBox txtPatientname;
        private TextBox txtPatientId;
        private Label label1;
        private Label label2;
    }
}