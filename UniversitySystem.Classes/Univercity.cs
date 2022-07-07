using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class Univercity
    {
        private string name;
        private int id;

        public string Name { get { return name; } set { name = value; } }
        public int Id { get { return id; } set { id = value; } }

        public Univercity(int id , string name)
        {
            this.name = name;
            this.id = id;
        }
        public Univercity() { }
    }
}
