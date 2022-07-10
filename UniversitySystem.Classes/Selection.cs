using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class Selection
    {
        private int id;
        private int capacity;
        private int collegeID;
        private int lessonID;
        private int teacherID;
        private int roomID;
        private int studentID;
        private DateTime datetime;
        private string name;

        public int ID { get { return id; } set { id = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int CollegeID { get { return collegeID; } set { collegeID = value; } }
        public int LessonID { get { return lessonID; } set { lessonID = value; } }
        public int TeacherID { get { return teacherID; } set { teacherID = value; } }
        public int RoomID { get { return roomID; } set { roomID = value; } }
        public int StudentID { get { return studentID; } set { studentID = value; } }
        public DateTime dateTime { get { return datetime; } set { datetime = value; } } 
        public string Name { get { return name; } set { name = value; } }

        public Selection() { }
    }
}
