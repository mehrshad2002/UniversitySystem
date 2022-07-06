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
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            int ID = Convert.ToInt32(txtID.Text);

            ServiceClass service = new ServiceClass();
            bool Result = service.DeleteUser(ID, Name);

            if( Result == true)
            {
                MessageBox.Show("Done!");
                txtID.ResetText();
                txtName.ResetText();
            }
            else
            {
                MessageBox.Show("Name Or ID Invalid.\nPlease Check Users List First.");
                txtID.ResetText();
                txtName.ResetText();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
    }
}

