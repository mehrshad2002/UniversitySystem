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

namespace UniversitySystem.WinApp.AdminForms
{
    public partial class EditTeacher : Form
    {
        public Teacher teacher; 
        public EditTeacher()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<College> AllCollege = service.ReadAllCollege();

            foreach (var item in AllCollege)
            {
                string UnivercityName = service.SayUnivercityName(Convert.ToInt32(item.UnivercityID));
                comboBoxCollege.Items.Add(item.Name + " --- " + UnivercityName + " --- College_ID : " + item.Id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();
            Teacher EditTeacher = new Teacher();


            if (txtName.Text == "")
            {
                txtName.Text = teacher.Name;

            }
            if (txtTeacherID.Text == "" )
            {
                txtTeacherID.Text = Convert.ToString(teacher.ID);

            }
            if (txtCollegeID.Text == "")
            {
                txtCollegeID.Text = Convert.ToString(teacher.CollegeID);

            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = teacher.Password;
            }

            EditTeacher.Name = txtName.Text;
            EditTeacher.ID = Convert.ToInt32(txtTeacherID.Text);
            EditTeacher.CollegeID = Convert.ToInt32(txtCollegeID.Text);//search coolege;
            EditTeacher.Password = Convert.ToString(txtPassword.Text);
            int OldID = EditTeacher.ID;
            bool Result = service.EditTeacher(EditTeacher , OldID );

            if( Result != true)
            {
                MessageBox.Show("Somthings Wrong");
                txtCollegeID.ResetText();
                txtTeacherID.ResetText();
                txtName.ResetText();
                txtPassword.ResetText();
            }
            else
            {
                MessageBox.Show("Done!");
                txtCollegeID.ResetText();
                txtTeacherID.ResetText();
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
