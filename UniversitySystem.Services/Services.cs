using UniversitySystem.Classes;
namespace UniversitySystem.Services
{
    using Repository;
    public class ServiceClass
    {
        Repository repository = new Repository();

        public bool Login(int username, string password , User user)
        {
            return repository.Login(username, password , user);
        }
    }
}