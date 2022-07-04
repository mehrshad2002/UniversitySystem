namespace UniversitySystem.Classes
{
    public class User
    {
        private string name;
        private string password;
        private int cardID;
        private int collegeID;
        private bool flagPass = false;//for login account 
        private int poss;



        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int CardID { get { return cardID; } set { cardID = value; } }
        public int CollegeID { get { return collegeID; } set { collegeID = value; } }
        public bool FlagPass { get { return flagPass; } set { flagPass = value; }  }
        public int Poss { get { return poss; } set { poss = value; } }



        public User()
        {

        }

        public User(string name, string password, int cardID, int collegeID, int poss)
        {
            this.name = name;
            this.password = password;
            this.cardID = cardID;
            this.collegeID = collegeID;
            this.poss = poss;
        }
    }
}