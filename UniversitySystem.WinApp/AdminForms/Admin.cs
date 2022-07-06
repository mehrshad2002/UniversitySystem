using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.WinApp.PersonnelForms;
using UniversitySystem.Classes;
using UniversitySystem.Services;
using UniversitySystem.WinApp.AdminForms;

namespace UniversitySystem.WinApp
{
    public partial class Admin : Form
    {
        public User user;
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            AddStudent addStu = new AddStudent();
            addStu.Show();
            this.Hide();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            ShowAllStudents showAll = new ShowAllStudents();
            this.Close();
            showAll.Show();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            RemoveUser removeStudent = new RemoveUser();
            this.Close();
            removeStudent.Show();
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            this.Close();
            editUser.Show();
        }

        private void btnAddUnivercity_Click(object sender, EventArgs e)
        {
            ServiceClass Service = new ServiceClass();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacher addTeacher = new AddTeacher();
            addTeacher.Show();
            this.Close();
        }

        private void btnRemoveTeacher_Click(object sender, EventArgs e)
        {
            RemoveTecher removeTecher = new RemoveTecher();
            this.Close();
            removeTecher.Show();
        }
    }
}
