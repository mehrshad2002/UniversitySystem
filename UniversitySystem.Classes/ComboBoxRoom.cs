using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class ComboBoxRoom
    {
        public int Value { get; set; }
        public int ID { get; set; }

        public override string ToString()
        {
            return Convert.ToString(ID);
        }
    }
}
