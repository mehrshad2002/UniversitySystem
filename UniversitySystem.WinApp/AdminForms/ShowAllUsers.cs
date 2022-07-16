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
    public partial class ShowAllUsers : Form
    {
        static int Flag = 1;
        public ShowAllUsers()
        {
            InitializeComponent();
            AddButtonColumn();
        }

        private void AddButtonColumn()
        {
            ServiceClass service = new ServiceClass();
            List<User> users = new List<User>();
            users = service.ShowAllData();
            dgUsers.DataSource = users ;
            if( Flag == 1)
            {
                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete";
                DeleteBtn.Text = "Delete";
                DeleteBtn.Name = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                dgUsers.Columns.Add(DeleteBtn);

                DataGridViewButtonColumn EditBtn = new DataGridViewButtonColumn();
                EditBtn.HeaderText = "Edit";
                EditBtn.Text = "Edit";
                EditBtn.Name = "Edit";
                EditBtn.UseColumnTextForButtonValue = true;
                dgUsers.Columns.Add(EditBtn);


                Flag = 0 ;
            }
        }

        private void dgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                ServiceClass service = new ServiceClass();
                int Counter = e.RowIndex ;
                bool Result = service.RemoveUsers(Counter);
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

            if(e.ColumnIndex == 5)
            {
                ServiceClass service = new ServiceClass();
                int Counter = e.RowIndex;
                User user = service.EditUsers(Counter);
                EditUsers editUsers = new EditUsers(user);
                editUsers.user = user;
                Flag = 1;
                this.Close();
                editUsers.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            Flag = 1;
            this.Close();
            admin.Show();
        }
    }
}
