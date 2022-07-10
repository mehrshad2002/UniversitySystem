using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class SelectionForStudentList
    {
        private int id;
        private string name;
        private int selectionID;

        public int ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int SelectionID { get { return selectionID; } set { selectionID = value; } }
        
        public SelectionForStudentList() { }
    }
}
