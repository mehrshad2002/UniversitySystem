using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class ComboBoxItems
    {
        public string Name { get; set; }
        public object CollegeID { get; set; }
        public string UnivercityName { get; set; }



        public override string ToString()
        {
            return (Name + " " + UnivercityName + " " +  CollegeID) ;
        }
    }
}
