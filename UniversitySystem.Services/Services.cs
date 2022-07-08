using UniversitySystem.Classes;
namespace UniversitySystem.Services
{
    using Repository;
    using System;
    using System.Collections.Generic;

    public class ServiceClass
    {
        Repository repository = new Repository();

        public bool Login(int username, string password , User user)
        {
            return repository.Login(username, password , user);
        }

        public bool AdminAddStudent( User NewUser )
        {
            return repository.AddStudent(NewUser);
        }

        public List<User> ShowAllData()
        {
            return repository.ShowAllData();
        }

        public List<Teacher> AllTeacher()
        {
            return repository.AllTeacher();
        }

        public List<College> ReadAllCollege()
        {
            return repository.ReadAllCollege();
        }

        public string SayUnivercityName(int ID)
        {
            return repository.SayUnivercityName( ID );
        }

        public bool DeleteUser(int ID, string Name)
        {
            return repository.DeleteUser(ID , Name );
        }

        public List<Univercity> ReadAllUnivercity()
        {
            return repository.ReadAllUnivercity();
        }

        public bool SearchUser(string name, int ID , User user)
        {
            return repository.SearchUser(name, ID , user );
        }

        public int FindUnivercityID(string findUnivercityID )
        {
            return repository.FinUnivercityID(findUnivercityID);
        }

        public bool SearchTeacher(Teacher teacher, int ID)
        {
            return repository.SearchTeacher(teacher, ID);
        }

        public bool AddCollege(College college)
        {
            return repository.AddCollege(college);
        }

        public bool DeleteCollege(int CollegeID)
        {
            return repository.DeleteCollege(CollegeID);
        }

        public bool EditTeacher(Teacher editTeacher ,  int oldID)
        {
            return repository.EditTeacher(editTeacher , oldID);
        }

        public bool AddUnivercity(Univercity univercity)
        {
            return repository.AddUnivercity(univercity);
        }

        public bool RemoveTeacher(string name, int ID )
        {
            return repository.RemoveTeacher(name, ID);
        }

        public bool AddTeacher(User user)
        {
            return repository.AddTeacher(user);
        }

        public bool EditUser( User editUser , User user )
        {
            return repository.EditUser(editUser ,  user );
        }
    }
}