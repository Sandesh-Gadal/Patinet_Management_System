
namespace mongodbConnection
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menupanel = new Panel();
            Logoutlinklabel = new LinkLabel();
            usershowbtn = new Button();
            appointmentbtn = new Button();
            updatebtn = new Button();
            addpatientbtn = new Button();
            AllpatientShowbtn = new Button();
            pictureBox1 = new PictureBox();
            dbpanel = new Panel();
            heropicbox = new PictureBox();
            menupanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            dbpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heropicbox).BeginInit();
            SuspendLayout();
            // 
            // menupanel
            // 
            menupanel.BackColor = Color.ForestGreen;
            menupanel.BorderStyle = BorderStyle.Fixed3D;
            menupanel.Controls.Add(Logoutlinklabel);
            menupanel.Controls.Add(usershowbtn);
            menupanel.Controls.Add(appointmentbtn);
            menupanel.Controls.Add(updatebtn);
            menupanel.Controls.Add(addpatientbtn);
            menupanel.Controls.Add(AllpatientShowbtn);
            menupanel.Controls.Add(pictureBox1);
            menupanel.Location = new Point(1, 0);
            menupanel.Name = "menupanel";
            menupanel.Size = new Size(166, 447);
            menupanel.TabIndex = 0;
            menupanel.Paint += panel1_Paint;
            // 
            // Logoutlinklabel
            // 
            Logoutlinklabel.AutoSize = true;
            Logoutlinklabel.Location = new Point(9, 424);
            Logoutlinklabel.Name = "Logoutlinklabel";
            Logoutlinklabel.Size = new Size(51, 15);
            Logoutlinklabel.TabIndex = 2;
            Logoutlinklabel.TabStop = true;
            Logoutlinklabel.Text = " Log out";
            Logoutlinklabel.LinkClicked += Logoutlinklabel_LinkClicked;
            // 
            // usershowbtn
            // 
            usershowbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usershowbtn.Location = new Point(9, 324);
            usershowbtn.Name = "usershowbtn";
            usershowbtn.Size = new Size(145, 41);
            usershowbtn.TabIndex = 1;
            usershowbtn.Text = "All user";
            usershowbtn.UseVisualStyleBackColor = true;
            usershowbtn.Click += usershowbtn_Click;
            // 
            // appointmentbtn
            // 
            appointmentbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentbtn.Location = new Point(9, 277);
            appointmentbtn.Name = "appointmentbtn";
            appointmentbtn.Size = new Size(145, 41);
            appointmentbtn.TabIndex = 1;
            appointmentbtn.Text = "Appointments";
            appointmentbtn.UseVisualStyleBackColor = true;
            appointmentbtn.Click += appointmentbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatebtn.Location = new Point(9, 230);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(145, 41);
            updatebtn.TabIndex = 1;
            updatebtn.Text = "Update Patients";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // addpatientbtn
            // 
            addpatientbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addpatientbtn.Location = new Point(9, 183);
            addpatientbtn.Name = "addpatientbtn";
            addpatientbtn.Size = new Size(145, 41);
            addpatientbtn.TabIndex = 1;
            addpatientbtn.Text = "Add Patients";
            addpatientbtn.UseVisualStyleBackColor = true;
            addpatientbtn.Click += addpatientbtn_Click;
            // 
            // AllpatientShowbtn
            // 
            AllpatientShowbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AllpatientShowbtn.Location = new Point(9, 136);
            AllpatientShowbtn.Name = "AllpatientShowbtn";
            AllpatientShowbtn.Size = new Size(145, 41);
            AllpatientShowbtn.TabIndex = 1;
            AllpatientShowbtn.Text = "All Patients";
            AllpatientShowbtn.UseVisualStyleBackColor = true;
            AllpatientShowbtn.Click += AllpatientShowbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dbpanel
            // 
            dbpanel.BackgroundImageLayout = ImageLayout.Stretch;
            dbpanel.BorderStyle = BorderStyle.FixedSingle;
            dbpanel.Controls.Add(heropicbox);
            dbpanel.Location = new Point(173, 0);
            dbpanel.Name = "dbpanel";
            dbpanel.Size = new Size(625, 447);
            dbpanel.TabIndex = 1;
            dbpanel.Paint += dbpanel_Paint;
            // 
            // heropicbox
            // 
            heropicbox.Image = (Image)resources.GetObject("heropicbox.Image");
            heropicbox.Location = new Point(-1, -1);
            heropicbox.Name = "heropicbox";
            heropicbox.Size = new Size(625, 447);
            heropicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            heropicbox.TabIndex = 0;
            heropicbox.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dbpanel);
            Controls.Add(menupanel);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            menupanel.ResumeLayout(false);
            menupanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            dbpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)heropicbox).EndInit();
            ResumeLayout(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Panel menupanel;
        private Panel dbpanel;
        private LinkLabel Logoutlinklabel;
        private Button AllpatientShowbtn;
        private PictureBox pictureBox1;
        private Button appointmentbtn;
        private Button updatebtn;
        private Button addpatientbtn;
        private Button usershowbtn;
        private PictureBox heropicbox;
    }
}