using System.Configuration;
using MongoDB.Driver;

namespace mongodbConnection
{
    public partial class AddPatient : Form
    {
        private IMongoCollection<Patient> patientCollection;
        public AddPatient()
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

        private void Addgroupbox_Enter(object sender, EventArgs e)
        {

        }
        public void changebtntext(string text , string  grptext)
        {
            addbtn.Text = text;
            Addgroupbox.Text = grptext;
           
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
             if(addbtn.Text =="Add Patient")
            {

                string fullName = txtfullname.Text;
                string gender = gendercmbbox.Text;
                string bloodGroup = bgroupcmbbox.Text;
                string address = txtaddress.Text;
                string phoneNumber = txtphoneno.Text;
                string disease = txtdisease.Text;


                var patient = new Patient
                {
                    Pid = int.Parse(txtpatient_id.Text),
                    fullName = fullName,
                    age = int.Parse(txtage.Text),
                    gender = gender,
                    bloodGroup = bloodGroup,
                    address = address,
                    phoneNumber = phoneNumber,
                    disease = disease
                };


                patientCollection.InsertOne(patient);
                MessageBox.Show("Patient Added successfully!");
                cleartextbox();
            }
            else if (addbtn.Text == "Update Details")
            {
              
                int patientIdToUpdate = int.Parse(txtpatient_id.Text);

                var filter = Builders<Patient>.Filter.Eq("Pid", patientIdToUpdate);

                var update = Builders<Patient>.Update
                    .Set("fullName", txtfullname.Text)
                    .Set("age", int.Parse(txtage.Text))
                    .Set("gender", gendercmbbox.Text)
                    .Set("bloodGroup", bgroupcmbbox.Text)
                    .Set("address", txtaddress.Text)
                    .Set("phoneNumber", txtphoneno.Text)
                    .Set("disease", txtdisease.Text);

                var result = patientCollection.UpdateOne(filter, update);

                if (result.ModifiedCount > 0)
                {
                    MessageBox.Show("Patient Updated successfully!");
                    cleartextbox();
                }
                else
                {
                    MessageBox.Show("No patient found with the provided ID!");
                }
            }
            else
            {
                MessageBox.Show("There was an error connecting to the database");
            }
        }

        private void cleartextbox()
        {
            txtpatient_id.Text = "";
            txtfullname.Text = "";
            txtage.Text = "";
            gendercmbbox.SelectedIndex = -1;
            bgroupcmbbox.SelectedIndex = -1;
            txtaddress.Text = "";
            txtphoneno.Text = "";
            txtdisease.Text = "";

        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void txtpatient_id_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpatient_id.Text) && addbtn.Text == "Update Details")
            {
                int patientId;
                if (int.TryParse(txtpatient_id.Text, out patientId))
                {
                    var filter = Builders<Patient>.Filter.Eq(p => p.Pid, patientId);
                    var patient = patientCollection.Find(filter).FirstOrDefault();

                    if (patient != null)
                    {
                        // Fill textboxes with patient data
                        txtfullname.Text = patient.fullName;
                        txtage.Text = patient.age.ToString();
                        gendercmbbox.Text = patient.gender;
                        bgroupcmbbox.Text = patient.bloodGroup;
                        txtaddress.Text = patient.address;
                        txtphoneno.Text = patient.phoneNumber;
                        txtdisease.Text = patient.disease;
                    }
                    else
                    {
                        MessageBox.Show("Patient not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cleartextbox();
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
