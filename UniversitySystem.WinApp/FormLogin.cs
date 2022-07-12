using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Services;
using UniversitySystem.Classes;
using UniversitySystem.WinApp.PersonnelForms;

namespace UniversitySystem.WinApp
{
    public partial class FormLogin : Form
    {
        ServiceClass service = new ServiceClass();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            var username = Convert.ToInt32(txtUsername.Text);
            var password = txtPassword.Text;


            if( user.FlagPass != true)
            {
                var result = service.Login(username, password , user);
                if (result)
                {
                    if(user.Poss == 400)
                    {
                        StudentMain studentMain = new StudentMain();
                        //studentMain.user = user
                        StudentMain.user = user;
                        studentMain.Show();
                        this.Hide();

                    }
                    else if( user.Poss == 300)
                    {
                        Admin admin = new Admin();
                        admin.user = user;
                        admin.Show();
                        this.Hide();
                    }
                }
                else
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Invalid Username Or Password");
                }
            }
            else
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowHidePassword.Checked)
            {
                chkShowHidePassword.Text = "Hide";
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                chkShowHidePassword.Text = "Show";
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
