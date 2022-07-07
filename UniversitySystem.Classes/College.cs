using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class College
    {
        private int id;
        private string name;
        private int univercityID;

        public string Name { get { return name; } set { name = value; } }
        public int UnivercityID { get { return univercityID; } set { univercityID = value; } }
        public int Id { get { return id; } set { id = value; } }

        public College() { }
    }
}
