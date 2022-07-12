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
            this.Close();
            formLogin.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            AddStudent addStu = new AddStudent();
            this.Close();
            addStu.Show();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            ShowAllUsers AllUsers = new ShowAllUsers();
            this.Close();
            AllUsers.Show();
            //ShowAllStudents showAll = new ShowAllStudents();
            //this.Close();
            //showAll.Show();
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
            AddUnivercity addUnivercity = new AddUnivercity();
            this.Close();
            addUnivercity.Show();

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

        private void button3_Click(object sender, EventArgs e)
        {
            
            AddCollege addCollege = new AddCollege();
            this.Close();
            addCollege.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveCollege removeCollege = new RemoveCollege();
            this.Close();
            removeCollege.Show();
        }

        private void btnShowAllTeacher_Click(object sender, EventArgs e)
        {
            ShowAllTeacher showAllTeacher = new ShowAllTeacher();
            showAllTeacher.Show();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            this.Close();
            addRoom.Show();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            RemoveRoom removeRoom = new RemoveRoom();
            this.Close();
            removeRoom.Show();
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            AddLesson addLesson = new AddLesson();
            this.Close();
            addLesson.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveLesson removeLesson = new RemoveLesson();
            this.Close();
            removeLesson.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateSelection createSelection = new CreateSelection();
            this.Close();
            createSelection.Show();
        }

        private void RemoveSelection_Click(object sender, EventArgs e)
        {
            RemoveSelection removeSelection = new RemoveSelection();
            this.Close();
            removeSelection.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveUnivercity removeUnivercity = new RemoveUnivercity();
            this.Close();
            removeUnivercity.Show();
        }
    }
}
