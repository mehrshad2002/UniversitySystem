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
    public partial class RemoveCollege : Form
    {
        public RemoveCollege()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<College> AllCollege = service.ReadAllCollege();

            foreach (var item in AllCollege)
            {
                string UnivercityName = service.SayUnivercityName(Convert.ToInt32(item.UnivercityID));
                comboBoxCollege.Items.Add(item.Name + " --- " + UnivercityName + " --- College_ID : " + item.Id);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();
            int CollegeID = Convert.ToInt32(txtIDInput.Text);
            bool Result = service.DeleteCollege(CollegeID);

            if( Result)
            {
                MessageBox.Show("Done");
                comboBoxCollege.ResetText();
                txtIDInput.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!");
                comboBoxCollege.ResetText();
                txtIDInput.ResetText();
            }
            //int FindUnivercityID = Convert.ToInt32(txtIDInput.Text);//college code 
            //int UnivercityID = service.FindUnivercityID(FindUnivercityID);

            //if (UnivercityID == 0)
            //{
            //    MessageBox.Show("Faild");
            //    comboBoxCollege.ResetText();
            //}
            //else
            //{
            //    bool Result = service.DeleteCollege(UnivercityID);
            //    if(Result)
            //    {
            //        MessageBox.Show("Done.");
            //        comboBoxCollege.ResetText();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Faild!");
            //        comboBoxCollege.ResetText();
            //    }
            //}

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }
    }
}
