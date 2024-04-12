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
    public partial class Users : Form
    {
        IMongoCollection<login> UserCollection;
        public Users()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userdetailsgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            var connnectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var dbname = MongoUrl.Create(connnectionString).DatabaseName;
            var mongoClient = new MongoClient(connnectionString);
            var database = mongoClient.GetDatabase(dbname);
            UserCollection = database.GetCollection<login>("login");
            Loaduserdata();

        }
        private void Loaduserdata()
        {
            var filterDefinition = Builders<login>.Filter.Empty;
            var patient = UserCollection.Find(filterDefinition).ToList();
            userdataGridView1.DataSource = patient;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();


            var filter = Builders<login>.Filter.Eq(p => p.username, username);
            var patients = UserCollection.Find(filter).ToList();

            if (patients.Count == 0)
            {
                MessageBox.Show("User not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Display search results in DataGridView
                userdataGridView1.DataSource = patients;
                txtusername.Text = "";
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();

            var filter = Builders<login>.Filter.Eq(p => p.username, username);
            var result = UserCollection.DeleteOne(filter);

            if (result.DeletedCount == 0)
            {
                MessageBox.Show("No User found with the provided username " + username + "", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loaduserdata();
                txtusername.Text = "";
            }
        }

        private void allshowbtn_Click(object sender, EventArgs e)
        {
            Loaduserdata();
        }
    }
}
