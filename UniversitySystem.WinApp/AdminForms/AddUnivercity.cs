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
            Random random = new Random();
            Univercity univercity = new Univercity();
            if(textBoxName.Text == " " || textBoxName.Text == "")
            {
                MessageBox.Show("Faild!");
            }
            else
            {
                univercity.Name = textBoxName.Text;
                univercity.Id = random.Next(45, 75 );

                ServiceClass service = new ServiceClass();
                bool Result = service.AddUnivercity(univercity);

                if( Result)
                {
                    MessageBox.Show("Univercity Was Created !");
                    textBoxName.ResetText();
                }
                else
                {
                    MessageBox.Show("Faild!");
                    textBoxName.ResetText();
                }
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
