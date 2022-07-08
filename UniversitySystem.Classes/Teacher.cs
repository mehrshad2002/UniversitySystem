using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class Teacher
    {
        private string name;
        private int id;
        private int collegeID;
        private string password;

        public string Name { get { return name; } set { name = value; } }
        public int ID { get { return id; } set { id = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int CollegeID { get { return collegeID; } set { collegeID = value; } }

        public Teacher() { }
    }
}
