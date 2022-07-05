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
    }
}