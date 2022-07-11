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
namespace UniversitySystem.WinApp.AdminForms
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<User> users = new List<User>();
            users = service.ShowAllData();
            dgUsers.DataSource = users;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            User user = new User();
            string name = textBoxName.Text;
            int ID = Convert.ToInt32(textBoxID.Text);


            ServiceClass service = new ServiceClass();
            bool Result = service.SearchUser(name, ID , user);
            if(Result == true)
            {
                ServiceClass service2 = new ServiceClass();
                MessageBox.Show("Done");

                EndEditUser endEditUser = new EndEditUser();
                endEditUser.user = user;
                this.Close();
                endEditUser.Show();

                textBoxID.ResetText();
                textBoxName.ResetText();

            }
            else
            {
                MessageBox.Show("Invalid ID Or Name ");
                textBoxID.ResetText();
                textBoxName.ResetText();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }
    }
}
