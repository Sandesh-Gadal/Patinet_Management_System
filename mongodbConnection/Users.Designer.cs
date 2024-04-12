namespace mongodbConnection
{
    partial class Users
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
            userdetailsgroupBox = new GroupBox();
            userdataGridView1 = new DataGridView();
            label1 = new Label();
            allshowbtn = new Button();
            groupBox2 = new GroupBox();
            insidegrpbox = new GroupBox();
            txtusername = new TextBox();
            deletebtn = new Button();
            label3 = new Label();
            searchbtn = new Button();
            userdetailsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userdataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            insidegrpbox.SuspendLayout();
            SuspendLayout();
            // 
            // userdetailsgroupBox
            // 
            userdetailsgroupBox.Controls.Add(userdataGridView1);
            userdetailsgroupBox.Controls.Add(label1);
            userdetailsgroupBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userdetailsgroupBox.Location = new Point(12, 12);
            userdetailsgroupBox.Name = "userdetailsgroupBox";
            userdetailsgroupBox.Size = new Size(585, 204);
            userdetailsgroupBox.TabIndex = 0;
            userdetailsgroupBox.TabStop = false;
            userdetailsgroupBox.Text = "User Details ";
            userdetailsgroupBox.Enter += userdetailsgroupBox_Enter;
            // 
            // userdataGridView1
            // 
            userdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userdataGridView1.Location = new Point(6, 55);
            userdataGridView1.Name = "userdataGridView1";
            userdataGridView1.Size = new Size(573, 141);
            userdataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 14);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 0;
            label1.Text = "All User Registered in the System";
            label1.Click += label1_Click;
            // 
            // allshowbtn
            // 
            allshowbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allshowbtn.Location = new Point(435, 222);
            allshowbtn.Name = "allshowbtn";
            allshowbtn.Size = new Size(147, 23);
            allshowbtn.TabIndex = 3;
            allshowbtn.Text = "Show All Users";
            allshowbtn.UseVisualStyleBackColor = true;
            allshowbtn.Click += allshowbtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(insidegrpbox);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 145);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search And Delete Section";
            // 
            // insidegrpbox
            // 
            insidegrpbox.Controls.Add(txtusername);
            insidegrpbox.Controls.Add(deletebtn);
            insidegrpbox.Controls.Add(label3);
            insidegrpbox.Controls.Add(searchbtn);
            insidegrpbox.Location = new Point(20, 24);
            insidegrpbox.Name = "insidegrpbox";
            insidegrpbox.Size = new Size(302, 114);
            insidegrpbox.TabIndex = 1;
            insidegrpbox.TabStop = false;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(115, 31);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(152, 25);
            txtusername.TabIndex = 1;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(156, 69);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(75, 23);
            deletebtn.TabIndex = 0;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 32);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 0;
            label3.Text = "Username :";
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(58, 69);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 0;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 408);
            Controls.Add(allshowbtn);
            Controls.Add(userdetailsgroupBox);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            userdetailsgroupBox.ResumeLayout(false);
            userdetailsgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userdataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            insidegrpbox.ResumeLayout(false);
            insidegrpbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox userdetailsgroupBox;
        private Label label1;
        private DataGridView userdataGridView1;
        private Button allshowbtn;
        private GroupBox groupBox2;
        private GroupBox insidegrpbox;
        private TextBox txtusername;
        private Label label3;
        private Button deletebtn;
        private Button searchbtn;
    }
}