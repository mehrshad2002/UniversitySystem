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
    public partial class RemoveSelection : Form
    {
        public RemoveSelection()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<Selection> selections = new List<Selection>();
            selections = service.AllSelection();
            dgSelection.DataSource = selections;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();
            int ID = Convert.ToInt32(txtID.Text);
            bool Result = service.RemoveSelection(ID);

            if (Result)
            {
                MessageBox.Show("Done");
                txtID.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!");
                txtID.ResetText();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }
    }
}
