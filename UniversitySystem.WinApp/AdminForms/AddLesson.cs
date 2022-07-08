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
    public partial class AddLesson : Form
    {
        public AddLesson()
        {
            InitializeComponent();

            ServiceClass service = new ServiceClass();
            List<College> colleges = new List<College>();
            colleges = service.ReadAllCollege();
            dgAllCollege.DataSource = colleges;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lesson lesson = new Lesson();
            ServiceClass service = new ServiceClass();

            lesson.Name = Convert.ToString(txtName.Text);
            lesson.ID = Convert.ToInt32(txtID.Text);
            lesson.CollegeID = Convert.ToInt32(txtCollegeID.Text);

            bool Result = service.AddLesson(lesson);

            if( Result)
            {
                MessageBox.Show("Done!");
                txtCollegeID.ResetText();
                txtID.ResetText();
                txtName.ResetText();
            }
            else
            {
                MessageBox.Show("Somthings Wrong !");
                txtCollegeID.ResetText();
                txtID.ResetText();
                txtName.ResetText();
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
