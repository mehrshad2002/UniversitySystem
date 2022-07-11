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
            ServiceClass service = new ServiceClass();
            List<Teacher> TeacherList = new List<Teacher>();
            TeacherList = service.AllTeacher();

            List<College> CollegeList = new List<College>();
            CollegeList = service.ReadAllCollege();

            List<CollegeAndUnivercity> CollegeAndUnivercityList = new List<CollegeAndUnivercity>();
            CollegeAndUnivercityList = service.ReadAllCollegeJoin();

            foreach(CollegeAndUnivercity college in CollegeAndUnivercityList)
            {
                comboBoxCollege.Items.Add(college.CollegeName + " " + college.UnivercityName + " " + college.CollegeID );
                comboBoxCollege.ValueMember = Convert.ToString(college.CollegeID);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();

            ServiceClass service = new ServiceClass();
            user.Name = txtName.Text;
            user.CardID = Convert.ToInt32(txtID.Text);
            user.CollegeID = Convert.ToInt32(comboBoxCollege.ValueMember);
            user.Password = txtPassword.Text;


            bool Result = service.AddTeacher(user);

            if( Result)
            {
                MessageBox.Show("Teacher Was Created.");
                comboBoxCollege.ResetText();
                txtName.ResetText();
                txtPassword.ResetText();
                txtID.ResetText();
            }
            else
            {
                MessageBox.Show("Somthings Wrong!");
                comboBoxCollege.ResetText();
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
