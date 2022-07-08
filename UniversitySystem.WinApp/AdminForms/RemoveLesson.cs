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
    public partial class RemoveLesson : Form
    {
        public RemoveLesson()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<Lesson> lessons = new List<Lesson>();
            lessons = service.AllLessons();
            dgLesson.DataSource = lessons;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            ServiceClass service = new ServiceClass();

            bool Result = service.RemoveLesson(ID);
            if(Result)
            {
                MessageBox.Show("Done!");
                txtID.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!");
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
