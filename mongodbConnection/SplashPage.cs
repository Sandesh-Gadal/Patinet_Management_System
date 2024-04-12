using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mongodbConnection
{
    public partial class SplashPage : Form
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        private void SplashPage_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    UpdateProgressBar(i);
                    Thread.Sleep(30);
                }
                OpenMainForm();
            }).Start();
        }


        private void OpenMainForm()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(OpenMainForm));
                return;
            }
            Hide();
            new loginpage().Show();
        }

      

        private void UpdateProgressBar(int value)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(UpdateProgressBar), value);
                return;
            }
            progressBar1.Value = value;
        }
    }
}
