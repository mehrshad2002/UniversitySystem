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
        public static int  Flag = 1;
        public RemoveSelection()
        {
            InitializeComponent();
            AddButtonColumn();

        }

        private void AddButtonColumn()
        {
            ServiceClass service = new ServiceClass();
            List<Selection> selections = new List<Selection>();
            selections = service.AllSelection();

            dgSelectionNew.DataSource = selections;
            if (Flag == 1)
            {
                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete";
                DeleteBtn.Text = "Delete";
                DeleteBtn.Name = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                dgSelectionNew.Columns.Add(DeleteBtn);

                Flag = 0;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            Flag = 1;
            this.Close();
            admin.Show();
        }

        private void dgSelectionNew_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                ServiceClass service = new ServiceClass();
                int Counter = e.RowIndex;
                bool Result = service.RemoveSelectionNew(Counter);
                if (Result)
                {
                    MessageBox.Show("Done!");
                    AddButtonColumn();
                }
                else
                {
                    MessageBox.Show("Faild!");
                }
            }
        }
    }
}
