using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace mongodbConnection
{
    public partial class Allpatient : Form
    {
        private IMongoCollection<Patient> patientCollection;
        public Allpatient()
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
            patientCollection = database.GetCollection<Patient>("patients");
        }


        private void Allpatient_Load(object sender, EventArgs e)
        {
            LoadPatientData();
        }
        private void LoadPatientData()
        {
            var filterDefinition = Builders<Patient>.Filter.Empty;
            var patient = patientCollection.Find(filterDefinition).ToList();
            patientdatagrid.DataSource = patient;
        }

        private void allshowbtn_Click(object sender, EventArgs e)
        {
            LoadPatientData();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string fullName = txtPatientname.Text.Trim();
            int pid; 
            if (!int.TryParse(txtPatientId.Text.Trim(), out pid))
            {
                MessageBox.Show("Invalid PID. Please enter a valid  PID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Patient>.Filter.Eq(p => p.Pid, pid) & Builders<Patient>.Filter.Eq(p => p.fullName, fullName);
            var patients = patientCollection.Find(filter).ToList();

            if (patients.Count == 0)
            {
                MessageBox.Show("Patient not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Display search results in DataGridView
                patientdatagrid.DataSource = patients;
                txtPatientname.Text = "";
                txtPatientId.Text = "";
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string fullName = txtPatientname.Text.Trim();
            int pid;

            if (!int.TryParse(txtPatientId.Text.Trim(), out pid))
            {
                MessageBox.Show("Invalid PID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var filter = Builders<Patient>.Filter.Eq(p => p.Pid, pid) & Builders<Patient>.Filter.Regex(p => p.fullName, new BsonRegularExpression(fullName, "i"));

            var result = patientCollection.DeleteOne(filter);

            if (result.DeletedCount == 0)
            {
                MessageBox.Show("No patients found with the provided criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPatientData();
                txtPatientname.Text = "";
                txtPatientId.Text = "";
            }
        }
    }
}
