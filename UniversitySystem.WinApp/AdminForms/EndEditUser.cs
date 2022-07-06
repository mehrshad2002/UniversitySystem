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
    public partial class EndEditUser : Form
    {
        public User user ;
        public EndEditUser()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();
            User editUser = new User();

            if( txtName.Text == "")
            {
                txtName.Text = user.Name;

            }if( txtID.Text == "")
            {
                txtID.Text = Convert.ToString(user.CardID);

            }if(txtCollegeID.Text == "")
            {
                txtCollegeID.Text = Convert.ToString(user.CollegeID);

            }if( txtPassword.Text == "" ) 
            {
                txtPassword.Text = user.Password;
            }


            editUser.Name = Convert.ToString(txtName.Text);
            editUser.CardID = Convert.ToInt32(txtID.Text);
            editUser.CollegeID = Convert.ToInt32(txtCollegeID.Text);
            editUser.Password = Convert.ToString(txtPassword.Text);



            bool Result = service.EditUser(editUser , user);

            if( Result)
            {
                MessageBox.Show("Done!\nUser Was Updated");
                this.Close();
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Faild!");
                this.Close();
                EditUser editUser1 = new EditUser();
                editUser1.Show();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            users.Add(user);
            dataGridAll.DataSource = users ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            this.Close();
            editUser.Show();
        }
    }
}
