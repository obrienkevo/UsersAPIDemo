using System.Collections.Generic;
using UsersAPIDemo.Models;

namespace UsersAPIDemo.Repository
{
    public interface IUserAPIRepo
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int Id);
        void CreateUser(User user);
    }
}