using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppImprove
{
    public partial class Login : Form
    {
        Config db = new Config();

        public static string SetValueUsername = "";
        public static string SetValueNameLogin = "";

        public Login()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `user_info` where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'");


            if (db.Count() == 1)
            {
                MessageBox.Show("Success you will Login as " + db.Results(0, "names"));
                SetValueUsername = db.Results(0,"username");
                SetValueNameLogin = db.Results(0, "names");
                Data data = new Data();
                data.Show();
            }
            else
                MessageBox.Show("Wrong username and password combination");

           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
