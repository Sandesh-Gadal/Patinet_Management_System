using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mongodbConnection
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            heropicbox.Enabled = true;
        }

        private void AllpatientShowbtn_Click(object sender, EventArgs e)
        {
            heropicbox.Enabled = false;
            dbpanel.Controls.Clear();
            Allpatient allpatient = new Allpatient();
            allpatient.TopLevel = false;
            allpatient.FormBorderStyle = FormBorderStyle.None;
            allpatient.Dock = DockStyle.Fill;
            dbpanel.Controls.Add(allpatient);
            allpatient.Show();
        }

        private void addpatientbtn_Click(object sender, EventArgs e)
        {
            heropicbox.Enabled = false;
            dbpanel.Controls.Clear();
            AddPatient addpatient = new AddPatient();
            addpatient.TopLevel = false;
            addpatient.FormBorderStyle = FormBorderStyle.None;
            addpatient.Dock = DockStyle.Fill;
            dbpanel.Controls.Add(addpatient);
            addpatient.changebtntext("Add Patient", "Add New Patient");
            addpatient.Show();
        }

        private void Logoutlinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                loginpage lp = new loginpage();
                lp.Show();
                this.Hide();
            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            heropicbox.Enabled = false;
            dbpanel.Controls.Clear();
            AddPatient addpatient = new AddPatient();
            addpatient.TopLevel = false;
            addpatient.FormBorderStyle = FormBorderStyle.None;
            addpatient.Dock = DockStyle.Fill;
            dbpanel.Controls.Add(addpatient);
            addpatient.changebtntext("Update Details", "Update Patient Details");
            addpatient.Show();
        }

        private void usershowbtn_Click(object sender, EventArgs e)
        {
            heropicbox.Enabled = false;
            dbpanel.Controls.Clear();
            Users us = new Users();
            us.TopLevel = false;
            us.FormBorderStyle = FormBorderStyle.None;
            us.Dock = DockStyle.Fill;
            dbpanel.Controls.Add(us);
            us.Show();
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            heropicbox.Enabled = false;
            dbpanel.Controls.Clear();
            listofappointment listappointment = new listofappointment();
            listappointment.TopLevel = false;
            listappointment.FormBorderStyle = FormBorderStyle.None;
            listappointment.Dock = DockStyle.Fill;
            dbpanel.Controls.Add(listappointment);
            listappointment.Show();
        }

        private void dbpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
