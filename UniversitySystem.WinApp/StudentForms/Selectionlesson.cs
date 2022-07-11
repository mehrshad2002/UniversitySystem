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

namespace UniversitySystem.WinApp.PersonnelForms
{
    public partial class Selectionlesson : Form
    {
        public User user;
        public Selectionlesson()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<Selection> selections = new List<Selection>();
            selections = service.AllSelection();
            dgSelections.DataSource = selections;
            List<CollegeAndUnivercity> collegeAndUnivercities = new List<CollegeAndUnivercity>();
            collegeAndUnivercities = service.ReadAllCollegeJoin();
            dgCollegeAndUnivercity.DataSource = collegeAndUnivercities;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ServiceClass service = new ServiceClass();
            int SelectionID = Convert.ToInt32(txtID.Text);
            int ID = random.Next(0,10000);
            int StudentID = user.CardID;

            bool Result = service.MainSelection(ID,SelectionID,StudentID);
            if (Result)
            {
                MessageBox.Show("Done");
                txtID.ResetText();
            }
            else
            {
                MessageBox.Show("Faild");
                txtID.ResetText();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentMain studentMain = new StudentMain();
            this.Close();
            studentMain.Show();
        }
    }
}
