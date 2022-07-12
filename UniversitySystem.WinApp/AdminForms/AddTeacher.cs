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
                ComboBoxItems comboBoxItems = new ComboBoxItems();
                comboBoxItems.CollegeID = college.CollegeID;
                comboBoxItems.Name = college.CollegeName;
                comboBoxItems.UnivercityName = college.UnivercityName;
                comboBoxCollege.Items.Add(comboBoxItems);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            Random random = new Random();
            ServiceClass service = new ServiceClass();
            user.Name = txtName.Text;
            user.CardID = random.Next(1, 1000);
            user.CollegeID = Convert.ToInt32((comboBoxCollege.SelectedItem as ComboBoxItems).CollegeID);
            user.Password = txtPassword.Text;

            bool Result = service.AddTeacher(user);

            if( Result)
            {
                MessageBox.Show("Teacher Was Created.");
                comboBoxCollege.ResetText();
                txtName.ResetText();
                txtPassword.ResetText();
            }
            else
            {
                MessageBox.Show("Somthings Wrong!");
                comboBoxCollege.ResetText();
                txtName.ResetText();
                txtPassword.ResetText();
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
