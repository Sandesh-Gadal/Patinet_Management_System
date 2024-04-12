using System.Configuration;
using MongoDB.Driver;

namespace mongodbConnection
{
    public partial class Appointment : Form
    {
        IMongoCollection<bookedappointment> appointmentCollection;
        private IMongoCollection<Patient> patientCollection;
        public Appointment()
        {
            InitializeComponent();
            InitializeMongoDB();
        }
        private void InitializeMongoDB()
        {

            var connnectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var dbname = MongoUrl.Create(connnectionString).DatabaseName;
            var mongoClient = new MongoClient(connnectionString);
            var database = mongoClient.GetDatabase(dbname);
            appointmentCollection = database.GetCollection<bookedappointment>("appointment");
            patientCollection = database.GetCollection<Patient>("patients");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void logoutlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                loginpage lp = new loginpage();
                lp.Show();
                this.Hide();
            }

        }

        private void bookbtn_Click(object sender, EventArgs e)
        {


            string patientName = txtpname.Text;
            int patientAge = int.Parse(txtage.Text);
            string patientGender = cmbgender.Text;
            string disease = txtdisease.Text;
            string doctor = cmbdoctor.Text;
            string chosenDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");


            var appointment = new bookedappointment
            {

                PatientName = patientName,
                PatientAge = patientAge,
                PatientGender = patientGender,
                Disease = disease,
                Doctor = doctor,
                ChosenDate = chosenDate
            };


            try
            {
                appointmentCollection.InsertOne(appointment);
                MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (listapp != null)
                {
                    listapp.LoadappointmentData();
                }
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Setappointmentlist(listofappointment lsa)
        {
            listapp = lsa;
        }
        private listofappointment listapp;
        private void ClearTextBoxes()
        {
            txtpid.Clear();
            txtpname.Clear();
            txtage.Clear();
            cmbgender.SelectedIndex = -1;
            txtdisease.Clear();
            cmbdoctor.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpid.Text))
            {
                int patientId;
                if (int.TryParse(txtpid.Text, out patientId))
                {
                    var filter = Builders<Patient>.Filter.Eq(p => p.Pid, patientId);
                    var patient = patientCollection.Find(filter).FirstOrDefault();

                    if (patient != null)
                    {
                      
                        txtpname.Text = patient.fullName;
                        txtage.Text = patient.age.ToString();
                        cmbgender.Text = patient.gender;
                        txtdisease.Text = patient.disease;
                    }
                    else
                    {
                        MessageBox.Show("Not Registered.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTextBoxes();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid patient ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
