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
using UniversitySystem.WinApp.StudentForms;
using UniversitySystem.WinApp.PersonnelForms;

namespace UniversitySystem.WinApp.StudentForms
{
    public partial class RemoveSelection : Form
    {
        public static User user;
        static int Flag = 1;

        public RemoveSelection(User NewUser)
        {
            InitializeComponent();
            user = NewUser;
            DataGridListSelection();
        }

        private void DataGridListSelection()
        {
            ServiceClass service = new ServiceClass();
            List<SelectionForStudentList> SelectionList = new List<SelectionForStudentList>();
            SelectionList = service.SelectionList(user.CardID);//find all selection related 
            dgAllSelection.DataSource = SelectionList;// All Data is Loaded 

            if( Flag == 1)
            {
                //Create Delete Button for Grid
                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete";
                DeleteBtn.Text = "Delete";
                DeleteBtn.Name = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                dgAllSelection.Columns.Add(DeleteBtn);

                //And Never Bulit Again 
                Flag = 0;
            }
        }

        private void dgAllSelection_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ServiceClass service = new ServiceClass();

            //Delete Click
            if(e.ColumnIndex == 2 )
            {
                int Counter = e.RowIndex;
                bool Result = service.RemoveSelectionLessonNew(Counter , user);
                if (Result)
                {
                    MessageBox.Show("Done");
                    DataGridListSelection();
                }
                else
                {
                    MessageBox.Show("Somthings Wrong");
                    DataGridListSelection();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentMain studentMain = new StudentMain();
            this.Close();
            studentMain.Show();
        }

    }
}
