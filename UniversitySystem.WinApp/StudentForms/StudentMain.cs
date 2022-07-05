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
    public partial class StudentMain : Form
    {
        public User user; 
        public StudentMain()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Close();
        }

        private void btnSelectionLesson_Click(object sender, EventArgs e)
        {
            ServiceClass serviceClass = new ServiceClass();
            //lesson selection
        }
    }
}
