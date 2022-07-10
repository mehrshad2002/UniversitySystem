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
using UniversitySystem.WinApp.StudentForms;
using UniversitySystem.WinApp.PersonnelForms;

namespace UniversitySystem.WinApp.StudentForms
{
    public partial class RemoveSelection : Form
    {
        public User user;
        public RemoveSelection(User user)
        {
            InitializeComponent();
            this.user = user;
            ServiceClass service = new ServiceClass();
            List<SelectionForStudentList> SelectionList = new List<SelectionForStudentList>();
            SelectionList = service.SelectionList();
            dgAllSelection.DataSource = SelectionList ;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();
            int ID = Convert.ToInt32(txtID.Text);
            bool Result = service.RemoveSelectionStudent(ID);

            if( Result)
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

        private void button2_Click(object sender, EventArgs e)
        {
            StudentMain studentMain = new StudentMain();
            this.Close();
            studentMain.Show();
        }
    }
}
