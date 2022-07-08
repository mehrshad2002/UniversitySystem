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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();

            //List<College> AllCollege = service.ReadAllCollegeJoin();
            List<CollegeAndUnivercity> AllCollegeJoin = service.ReadAllCollegeJoin();

            dgCollege.DataSource = AllCollegeJoin ;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();

            if(txtCollegeID.Text == "")
            {
                txtCollegeID.Text = "0";
            }
            int ID = Convert.ToInt32(txtID.Text);
            int CollegeID = Convert.ToInt32(txtCollegeID.Text);
            bool Result = service.AddRoom(ID, CollegeID);

            if(Result )
            {
                MessageBox.Show("Done");
                txtCollegeID.ResetText();
                txtID.ResetText();
            }
            else
            {
                MessageBox.Show("Faild,Check Correct College ID first !");
                txtCollegeID.ResetText();
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
