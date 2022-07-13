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
        public static User user;
        public Selectionlesson(User u)
        {
            user = u;
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<Selection> selections = new List<Selection>();
            //selections = service.AllSelection();
            selections = service.AllSelectionNew(user.CollegeID); 



            List<CollegeAndUnivercity> collegeAndUnivercities = new List<CollegeAndUnivercity>();
            collegeAndUnivercities = service.ReadAllCollegeJoin();

            foreach( Selection selection in selections)
            {
                ComboBoxSelection cbSelection = new ComboBoxSelection();
                cbSelection.Name = selection.Name;
                cbSelection.dateTime = Convert.ToDateTime(selection.dateTime);
                cbSelection.ID = selection.ID;
                comboBoxSelection.Items.Add(cbSelection);
            }
        }

        private void ComboBoxListValue()
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ServiceClass service = new ServiceClass();

            if(comboBoxSelection.Text == "")
            {
                MessageBox.Show("Invalid Selection Name Or ID\nTry Again");
            }
            else
            {
                int SelectionID = Convert.ToInt32((comboBoxSelection.SelectedItem as ComboBoxSelection).ID);
                int ID = random.Next(2000,5000);
                int StudentID = user.CardID;

                bool Result = service.MainSelection(ID,SelectionID,StudentID);
                if (Result)
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("Faild");
                }
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
