using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Classes;
using UniversitySystem.Services;
using UniversitySystem.WinApp.AdminForms;

namespace UniversitySystem.WinApp.AdminForms
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();

            ServiceClass service = new ServiceClass();
            user.Name = txtName.Text;
            user.CardID = Convert.ToInt32(txtID.Text);
            user.CollegeID = Convert.ToInt32((comboBox1.Text).Substring(0, 4));
            user.Password = txtPassword.Text;


            bool Result = service.AddTeacher(user);

            if( Result)
            {
                MessageBox.Show("Teacher Was Created.");
                comboBox1.ResetText();
                txtName.ResetText();
                txtPassword.ResetText();
                txtID.ResetText();
            }
            else
            {
                MessageBox.Show("Somthings Wrong!");
                comboBox1.ResetText();
                txtName.ResetText();
                txtPassword.ResetText();
                txtID.ResetText();
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
