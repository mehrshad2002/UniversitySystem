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

        public bool DeleteUser(int ID, string Name)
        {
            return repository.DeleteUser(ID , Name );
        }

        public bool SearchUser(string name, int ID , User user)
        {
            return repository.SearchUser(name, ID , user );
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