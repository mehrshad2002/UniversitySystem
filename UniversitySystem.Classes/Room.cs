using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class Room
    {
        private int id;
        private int collageID;

        public int ID { get { return id; } set { id = value; } }
        public int CollageID { get { return collageID; } set { collageID = value; } }

        public Room() { }
    }
}
