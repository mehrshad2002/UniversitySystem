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



            List<CollegeAndUnivercity> CollAndUni = new List<CollegeAndUnivercity>();
            CollAndUni = service.ReadAllCollegeJoin();

            foreach(CollegeAndUnivercity college in CollAndUni)
            {
                ComboBoxItems combo = new ComboBoxItems();
                combo.Name = college.CollegeName;
                combo.CollegeID = Convert.ToString(college.CollegeID);
                combo.UnivercityName = college.UnivercityName;
                comboBoxCollegeID.Items.Add(combo);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ServiceClass service = new ServiceClass();

            if(numberCapacity.Value < 5  )
            {
                numberCapacity.Value = 5;
            }
            int Capacity = Convert.ToInt32(numberCapacity.Value);
            int ID = Convert.ToInt32(txtID.Text);
            int CollegeID = Convert.ToInt32((comboBoxCollegeID.SelectedItem as ComboBoxItems).CollegeID);
            int LessonID = Convert.ToInt32(txtLessonID.Text);
            string Name = service.SayLessonName(LessonID);
            int RoomID = Convert.ToInt32((ComBoRoomID.SelectedItem as ComboBoxRoom).Value);
            int TeacherID = Convert.ToInt32((comboBoxTeacher.SelectedItem as ComboBoxTeacher).ID);
            DateTime dateTime = dtValue.Value.Date + dtValue.Value.TimeOfDay;

            bool Result = service.CreateSelection(ID,Capacity , CollegeID , LessonID , RoomID , TeacherID ,dateTime , Name);
            if (Result)
            {
                MessageBox.Show("Done!");
                numberCapacity.ResetText();
                txtID.ResetText();
                txtLessonID.ResetText();
                dtValue.ResetText();
            }
            else
            {
                MessageBox.Show("Faild!");
                numberCapacity.ResetText();
                txtID.ResetText();
                txtLessonID.ResetText();
                dtValue.ResetText();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Close();
            admin.Show();
        }

        private void comboBoxCollegeID_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCollegeID_TextChanged(object sender, EventArgs e)
        {

            comboBoxTeacher.Items.Clear();
            ComBoRoomID.Items.Clear();
            comboBoxLesson.Items.Clear();

            ServiceClass service = new ServiceClass();
            var CollegeValueID = (comboBoxCollegeID.SelectedItem as ComboBoxItems).CollegeID ;
            //Use this for validation 
            int CollegeID = Convert.ToInt32(CollegeValueID);
            List<Room> rooms = service.AllRoomForCreation(CollegeID);
            foreach (Room room in rooms)
            {
                ComboBoxRoom comboBoxRoom = new ComboBoxRoom();
                comboBoxRoom.ID = Convert.ToInt32(room.ID);
                comboBoxRoom.Value = Convert.ToInt32(room.ID);
                ComBoRoomID.Items.Add(comboBoxRoom);
            }

            List<Teacher> teachers = service.AllTeacherForCreation(CollegeID);
            foreach(Teacher teacher in teachers)
            {
                ComboBoxTeacher comboTeacher = new ComboBoxTeacher();
                comboTeacher.ID = Convert.ToInt32(teacher.ID);
                comboTeacher.Name = Convert.ToString(teacher.Name);
                comboBoxTeacher.Items.Add(comboTeacher);
            }

            List<Lesson> lessons = new List<Lesson>();
            lessons = service.AlllessonCreate(CollegeID);
            foreach (Lesson lesson in lessons)
            {
                ComboBoxLesson ObjLesson = new ComboBoxLesson();
                ObjLesson.Name = lesson.Name;
                ObjLesson.ID = Convert.ToInt32(lesson.ID);
                comboBoxLesson.Items.Add(ObjLesson);
            }
        }
    }
}
