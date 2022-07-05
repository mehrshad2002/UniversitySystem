﻿using System;
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NewUser = new User();
            var name = textBoxName.Text;
            var StudentID = Convert.ToInt32(textBoxStudentID.Text);
            var CollegeID = Convert.ToInt32(textBoxCollegeID.Text);
            var Password = textBoxPassword.Text;

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
                textBoxCollegeID.ResetText();
                textBoxPassword.ResetText();
                textBoxStudentID.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!\nSame Student_ID Or Invalid Data.\nPlease Check Student ID first");
                textBoxName.ResetText();
                textBoxCollegeID.ResetText();
                textBoxPassword.ResetText();
                textBoxStudentID.ResetText();
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
