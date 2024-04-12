using System.Configuration;
using MongoDB.Driver;

namespace mongodbConnection
{
    public partial class loginpage : Form
    {

        IMongoCollection<admin> AdminUserCollection;
        IMongoCollection<login> UserCollection;
        public loginpage()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            var username = txtusername.Text;
            var password = txtpassword.Text;

            var filter = Builders<login>.Filter.Eq(x => x.username, username) &
                         Builders<login>.Filter.Eq(x => x.password, password);

            var user = UserCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
               Appointment appointment = new Appointment();
                appointment.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            var register = new admin
            {
                admin_username = txtusername.Text,
                admin_password = txtpassword.Text,

            };
            AdminUserCollection.InsertOne(register);

        }

        private void loginpage_Load(object sender, EventArgs e)
        {
            var connnectionString = ConfigurationManager.ConnectionStrings["Dbconnection"].ConnectionString;
            var dbname = MongoUrl.Create(connnectionString).DatabaseName;
            var mongoClient = new MongoClient(connnectionString);
            var database = mongoClient.GetDatabase(dbname);
            UserCollection = database.GetCollection<login>("login");
            AdminUserCollection = database.GetCollection<admin>("admin");
        }

        private void adminloginbtn_Click(object sender, EventArgs e)
        {
            var adminusername = txtusername.Text;
            var adminpassword = txtpassword.Text;

            var filter = Builders<admin>.Filter.Eq(x => x.admin_username, adminusername) &
                         Builders<admin>.Filter.Eq(x => x.admin_password, adminpassword);

            var adminuser = AdminUserCollection.Find(filter).FirstOrDefault();

            if (adminuser != null)
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Dashboard db = new Dashboard();
                db.Show();

            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup sp = new Signup();
            sp.Show();
        }
    }
}
