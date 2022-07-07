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
    public partial class AddUnivercity : Form
    {
        public AddUnivercity()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Univercity univercity = new Univercity();
            univercity.Name = textBoxName.Text;
            univercity.Id = Convert.ToInt32(textBoxID.Text);

            ServiceClass service = new ServiceClass();
            bool Result = service.AddUnivercity(univercity);

            if( Result)
            {
                MessageBox.Show("Univercity Was Created !");
                textBoxID.ResetText();
                textBoxName.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!");
                textBoxID.ResetText();
                textBoxName.ResetText();
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
