using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Register : Form
    {

        Config db = new Config();
        public Register()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO `user_info` (`names`,`username`,`password`) VALUES ('" + txtName.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "')");
            this.Close();
        }
    }
}
