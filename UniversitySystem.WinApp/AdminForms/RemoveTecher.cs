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
using UniversitySystem.WinApp.AdminForms;


namespace UniversitySystem.WinApp.AdminForms
{
    public partial class RemoveTecher : Form
    {
        public RemoveTecher()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();

            string Name = txtName.Text;
            int ID = Convert.ToInt32(txtID.Text);

            bool Result = service.RemoveTeacher(Name , ID );

            if( Result)
            {
                MessageBox.Show("Done!");
                txtID.ResetText();
                txtName.ResetText();
            }
            else
            {
                MessageBox.Show("Faild,Please Check ID and Name.");
                txtID.ResetText();
                txtName.ResetText();
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
