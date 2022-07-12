using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class ComboBoxSelection
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime dateTime { get; set; }

        public override string ToString()
        {
            return ( Name + " " + dateTime );
        }
    }
}
