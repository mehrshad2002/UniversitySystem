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

namespace UniversitySystem.WinApp
{
    public partial class RemoveUnivercity : Form
    {
        public RemoveUnivercity()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<Univercity> univercities = new List<Univercity>();
            univercities = service.ReadAllUnivercity();
            dgUni.DataSource = univercities;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();
            if( txtID.Text == "")
            {
                txtID.Text = "0";
            }
            int ID =Convert.ToInt32(txtID.Text);

            bool Result = service.RemoveUnivercity(ID);

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
    }
}
