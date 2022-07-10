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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
