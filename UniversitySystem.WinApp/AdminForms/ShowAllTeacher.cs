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
    public partial class ShowAllTeacher : Form
    {
        public ShowAllTeacher()
        {
            InitializeComponent();

            ServiceClass service = new ServiceClass();
            List<Teacher> AllTeacher = service.AllTeacher();
            dgAllTeacher.DataSource = AllTeacher;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)//search btn 
        {
            //FOR CORRECT DATA
            if(txtID.Text == "")
            {
                txtID.Text = "0";
            }


            int ID = Convert.ToInt32(txtID.Text);
            ServiceClass service = new ServiceClass();
            EditTeacher editteacher = new EditTeacher();
            Teacher teacher = new Teacher();
            bool Result = service.SearchTeacher(teacher, ID);

            if( Result != true)
            {
                MessageBox.Show("Teacher Not Find!");
                txtID.ResetText();
            }
            else
            {
                editteacher.teacher = teacher;
                this.Close();
                editteacher.Show();
            }
        }
    }
}
