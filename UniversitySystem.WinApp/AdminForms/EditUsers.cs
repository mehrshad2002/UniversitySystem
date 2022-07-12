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
    public partial class EditUsers : Form
    {
        public User user;
        public EditUsers(User CurrentUser)
        {
            InitializeComponent( );

            ServiceClass service = new ServiceClass();
            txtID.Text = Convert.ToString(CurrentUser.CardID);
            txtPassword.Text = CurrentUser.Password;
            txtName.Text = CurrentUser.Name;


            comboBoxCollegeID.Text = Convert.ToString(CurrentUser.CollegeID);
            List<CollegeAndUnivercity> colleges = new List<CollegeAndUnivercity>();
            colleges = service.ReadAllCollegeJoin();
            foreach(CollegeAndUnivercity college in colleges)
            {
                comboBoxCollegeID.Items.Add(college.CollegeID + " " + college.CollegeName + " " + college.UnivercityName);
                comboBoxCollegeID.ValueMember = Convert.ToString(college.CollegeID);
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAllUsers showAllUsers = new ShowAllUsers();
            this.Close();
            showAllUsers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            ServiceClass service = new ServiceClass();
            int OldID = user.CardID;
            newUser.Name = txtName.Text;
            newUser.Password= txtPassword.Text;
            newUser.CardID  = Convert.ToInt32(txtID.Text);
            newUser.CollegeID  = Convert.ToInt32(comboBoxCollegeID.ValueMember);

            int i = 0;

            bool Result = service.SaveEditUser(newUser , OldID);
            if (Result)
            {
                MessageBox.Show("Done");
                ShowAllUsers showAllUsers = new ShowAllUsers();
                this.Close();
                showAllUsers.Show();
            }
            else
            {
                MessageBox.Show("Faild");
                ShowAllUsers showAllUsers = new ShowAllUsers();
                this.Close();
                showAllUsers.Show();
            }
        }
    }
}
