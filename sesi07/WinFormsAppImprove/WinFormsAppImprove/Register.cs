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
            db.ExecuteSelect($"SELECT * FROM `user_info` WHERE username='{txtUName.Text}' ");


            if (db.Count() != 0)
            {
                MessageBox.Show("Username has been used!");
            }
            else
            {
                if (txtPassword.Text != txtCPassword.Text)
                {
                    MessageBox.Show("Password not valid");
                }
                else
                {
                    db.Execute($"INSERT INTO `user_info` (`id`,`names`,`username`,`password`) VALUES (NULL, '{txtName.Text}', '{txtUName.Text}', '{txtPassword.Text}')");

                    MessageBox.Show("Registered!");
                    this.Close();
                }
            }

        }
    }
}
