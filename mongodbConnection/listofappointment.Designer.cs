namespace mongodbConnection
{
    partial class listofappointment
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
            button2 = new Button();
            DeleteBtn = new Button();
            appointmentgrid = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentgrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(179, 30);
            label1.TabIndex = 0;
            label1.Text = "Appointment List";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(DeleteBtn);
            groupBox1.Controls.Add(appointmentgrid);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(572, 326);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // button2
            // 
            button2.Location = new Point(440, 257);
            button2.Name = "button2";
            button2.Size = new Size(109, 33);
            button2.TabIndex = 1;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(311, 257);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(109, 33);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // appointmentgrid
            // 
            appointmentgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentgrid.Location = new Point(6, 28);
            appointmentgrid.Name = "appointmentgrid";
            appointmentgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentgrid.Size = new Size(560, 211);
            appointmentgrid.TabIndex = 0;
            // 
            // listofappointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 408);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listofappointment";
            Text = "listofappointment";
            Load += listofappointment_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)appointmentgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button2;
        private Button DeleteBtn;
        private DataGridView appointmentgrid;
    }
}