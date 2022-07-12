using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitySystem.Services;
using UniversitySystem.Classes;


namespace UniversitySystem.WinApp.AdminForms
{
    public partial class ShowAllStudents : Form
    {
        public ShowAllStudents()
        {
            InitializeComponent();
            ServiceClass serviceClass = new ServiceClass();
            List<User> ListUser = serviceClass.ShowAllData();
            dataGridAllData.DataSource = ListUser;

            // create Column which is Button
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Text = "Edit";
            btn.Name = "Land";
            btn.UseColumnTextForButtonValue = true;
            dataGridAllData.Columns.Add(btn);

            int columnIndex = 0;
            if (dataGridAllData.Columns["Land"] == null)
            {
                dataGridAllData.Columns.Insert(columnIndex, btn);
            }
            dataGridAllData.CellClick += dataGridAllData_CellClick;
            userBindingSource.DataSource = ListUser;
            dataGridAllData.DataSource = ListUser;
        }

        private void dataGridAllData_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
        }

        //useless
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void ShowAllStudents_Load(object sender, EventArgs e)
        {
        }

        private void dtOne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
