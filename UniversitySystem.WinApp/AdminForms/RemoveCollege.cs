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
    public partial class RemoveCollege : Form
    {
        public static int Flag  = 1 ; 
        public RemoveCollege()
        {
            InitializeComponent();
            DataGridDeleteList();
        }

        private void DataGridDeleteList()
        {
            ServiceClass service = new ServiceClass();
            List<CollegeAndUnivercity> colleges = new List<CollegeAndUnivercity>();
            colleges = service.ReadAllCollegeJoin();
            dgCollege.DataSource = colleges ;

            if( Flag == 1)
            {
                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete";
                DeleteBtn.Text = "Delete";
                DeleteBtn.Name = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                dgCollege.Columns.Add(DeleteBtn);

                Flag = 0;
            }
        }
        private void dgCollege_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ServiceClass service = new ServiceClass();
                int Counter = e.RowIndex;
                bool Result = service.RemoveCollegeNew(Counter);
                if (Result)
                {
                    MessageBox.Show("Done!");
                    DataGridDeleteList();
                }
                else
                {
                    MessageBox.Show("Faild!");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
