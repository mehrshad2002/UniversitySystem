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
    public partial class AddStudent : Form
    {
        public User NewUser  ; 
        public AddStudent()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<CollegeAndUnivercity> collegeAndUnivercities = new List<CollegeAndUnivercity>();
            collegeAndUnivercities = service.ReadAllCollegeJoin();
            dgCollege.DataSource = collegeAndUnivercities;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            NewUser = new User();
            
            string name = textBoxName.Text;
            int StudentID = 4000000;
            StudentID += random.Next(1000,9999);
            int i = 0;
            string Password = textBoxPassword.Text;
            int CollegeID = Convert.ToInt32(txtCollegeID.Text);

            //Add Value To NewUser
            NewUser.Password = Password;
            NewUser.CardID = StudentID;
            NewUser.Name = name;
            NewUser.CollegeID = CollegeID;
            

            ServiceClass service = new ServiceClass();
            bool Result = service.AdminAddStudent(NewUser);

            if( Result == true)
            {
                MessageBox.Show("Done!");
                textBoxName.ResetText();
                textBoxPassword.ResetText();
                txtCollegeID.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!\nSame Student_ID Or Invalid Data.\nPlease Check Student ID first");
                textBoxName.ResetText();
                textBoxPassword.ResetText();
                txtCollegeID.ResetText();
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
