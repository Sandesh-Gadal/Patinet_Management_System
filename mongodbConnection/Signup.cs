using MongoDB.Driver;
using System.Configuration;

namespace mongodbConnection
{
    public partial class Signup : Form
    {
        IMongoCollection<login> UserCollection;
        loginpage lp = new loginpage();
        public Signup()
        {
            InitializeComponent();
        }

        private void backtologinlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
           
            lp.Show();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string firstname = txtfname.Text;
            string lastname = txtlname.Text;
            decimal age = decimal.Parse(txtage.Text); 
            string address = txtaddress.Text;
            string username = txtusername.Text;
            string password = txtpassword.Text;

           
            var newUser = new login
            {
                firstname = firstname,
                lastname = lastname,
                age = age,
                address = address,
                username = username,
                password = password
            };

           
            try
            {
                UserCollection.InsertOne(newUser);
                MessageBox.Show("User Registered successfully!");
                ClearTextBoxes();
                this.Hide();
                lp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Registering user: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            txtfname.Text = "";
            txtlname.Text = "";
            txtage.Text = "";
            txtaddress.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
        }

    }
}
