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
using MongoDB.Driver;

namespace mongodbConnection
{
    public partial class listofappointment : Form
    {

        IMongoCollection<bookedappointment> appointmentCollection;
        public listofappointment()
        {
            InitializeComponent();
        }

        private void listofappointment_Load(object sender, EventArgs e)
        {
            var connnectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var dbname = MongoUrl.Create(connnectionString).DatabaseName;
            var mongoClient = new MongoClient(connnectionString);
            var database = mongoClient.GetDatabase(dbname);
            appointmentCollection = database.GetCollection<bookedappointment>("appointment");
            LoadappointmentData();
        }

        public void LoadappointmentData()
        {
            var filterDefinition = Builders<bookedappointment>.Filter.Empty;
            var patient = appointmentCollection.Find(filterDefinition).ToList();
            appointmentgrid.DataSource = patient;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appointment ap = new Appointment();
            ap.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (appointmentgrid.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = appointmentgrid.SelectedRows[0];

                // Extract the unique identifier of the appointment from the selected row
                string patientname = selectedRow.Cells["PatientName"].Value.ToString();


                var filter = Builders<bookedappointment>.Filter.Eq("PatientName", patientname);
                appointmentCollection.DeleteOne(filter);


                LoadappointmentData();
            }
        }
    }
}
