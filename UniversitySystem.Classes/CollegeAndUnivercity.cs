using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Classes
{
    public class CollegeAndUnivercity
    {
        private string collegeName;
        private string univercityName;
        private int collegeID;
        
        public int CollegeID { get { return collegeID; } set { collegeID = value; } }
        public string UnivercityName { get { return univercityName; } set { univercityName = value; } }
        public string CollegeName { get { return collegeName; } set { collegeName = value  ; } }    

        public CollegeAndUnivercity() { }
    }
}
