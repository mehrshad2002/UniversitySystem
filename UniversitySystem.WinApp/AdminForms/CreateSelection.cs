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
    public partial class CreateSelection : Form
    {
        public CreateSelection()
        {
            InitializeComponent();
            ServiceClass service = new ServiceClass();
            List<College> colleges = new List<College>();
            List<Teacher> teachers = new List<Teacher>();
            List<Lesson> lessons = new List<Lesson>();
            List<Room> rooms = new List<Room>();

            colleges = service.ReadAllCollege();
            teachers = service.AllTeacher();
            lessons = service.AllLessons();
            rooms = service.AllRoom();

            dgCollege.DataSource = colleges;
            dgLesson.DataSource = lessons;
            dgRoom.DataSource = rooms;
            dgTeacher.DataSource = teachers;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();


            int Capacity = Convert.ToInt32(numberCapacity.Value);
            int ID = Convert.ToInt32(txtID.Text);
            int CollegeID = Convert.ToInt32(txtCollegeID.Text);
            int LessonID = Convert.ToInt32(txtLessonID.Text);
            string Name = service.SayLessonName(LessonID);
            int RoomID = Convert.ToInt32(txtRoom.Text);
            int TeacherID = Convert.ToInt32(txtTeacherID.Text);
            DateTime dateTime = dtValue.Value.Date + dtValue.Value.TimeOfDay;

            bool Result = service.CreateSelection(ID,Capacity , CollegeID , LessonID , RoomID , TeacherID ,dateTime );
            if (Result)
            {
                MessageBox.Show("Done!");
                numberCapacity.ResetText();
                txtID.ResetText();
                txtLessonID.ResetText();
                txtCollegeID.ResetText();
                txtRoom.ResetText();
                txtTeacherID.ResetText();
                dtValue.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!");
                numberCapacity.ResetText();
                txtID.ResetText();
                txtLessonID.ResetText();
                txtCollegeID.ResetText();
                txtRoom.ResetText();
                txtTeacherID.ResetText();
                dtValue.ResetText();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }
    }
}
