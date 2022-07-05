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
            showAll.Show();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            RemoveStudent removeStudent = new RemoveStudent();
            removeStudent.Show();
        }
    }
}
