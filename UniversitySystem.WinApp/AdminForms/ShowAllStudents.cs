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
            DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
            uninstallButtonColumn.Name = "Land";
            uninstallButtonColumn.Text = "Edit";
            int columnIndex = 2;
            if (dataGridAllData.Columns["Land"] == null)
            {
                dataGridAllData.Columns.Insert(columnIndex, uninstallButtonColumn);
            }
            dataGridAllData.CellClick += dataGridAllData_CellClick;

        }

        private void dataGridAllData_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //ServiceClass serviceClass = new ServiceClass();
            //List<User> ListUser =  serviceClass.ShowAllData();
            //dataGridAllData.DataSource = ListUser;
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

        private void dataGridAllData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
