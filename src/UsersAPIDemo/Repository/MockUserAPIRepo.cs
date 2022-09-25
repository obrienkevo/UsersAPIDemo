using System.Collections.Generic;
using UsersAPIDemo.Models;

namespace UsersAPIDemo.Repository
{
    public class MockUserAPIRepo2 : IUserAPIRepo
    {
        public void CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }

        public User GetUserById(int Id)
        {
            var user = new User{
                UserID = 5,
                Username = "testuser5",
                Email = "testuser5@myemail.com"
            };
            return user;
        }
    }
    public class MockUserAPIRepo : IUserAPIRepo
    {
        public void CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = new List<User>
            {
                new User{
                    UserID = 1,
                    Username = "kxobri2",
                    Email = "kevin.obrien@myemail.com"
                },
                new User{
                    UserID = 2,
                    Username = "txmall",
                    Email = "john.doe@myemail.com"
                }
            };

            return users;
        }

        public User GetUserById(int Id)
        {
            var user = new User{
                UserID = 1,
                Username = "kxobri2",
                Email = "kevin.obrien@myemail.com"
            };
            return user;
        }
    }
}