using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class Lesson
    {
        private string name;
        private int id;
        private int collegeID;

        public string Name { get { return name; } set { name = value; } }
        public int ID { get { return id; } set { id = value; } }
        public int CollegeID { get { return collegeID; } set { collegeID = value; } }

        public Lesson() { }
    }
}
