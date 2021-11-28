using System.Collections.Generic;
using WebAPI.Model;
using System.Linq;
using Entities.Model;

namespace WebAPI.Data
{
    public class InMemoryUserService :IUserService
    {
        private List<User> users;
        public InMemoryUserService() {
            users = new List<User>( new[] {
                new User {
                    City = "Horsens",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Teacher",
                    BirthYear = 1987,
                    SecurityLevel = 3,
                    UserName = "Troels"
                },
                new User {
                    City = "Aarhus",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "Student",
                    BirthYear = 2000,
                    SecurityLevel = 4,
                    UserName = "Lukas"
                },
                new User {
                    City = "Aarhus",
                    Domain = "via.dk",
                    Password = "123456",
                    Role = "",
                    BirthYear = 2000,
                    SecurityLevel = 4,
                    UserName = "Admin"
                },
            });
        }

        public User ValidateUser(string userName, string password){
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null){
                throw new System.Exception("User not found");
            }

            if (!first.Password.Equals(password)){
                throw new System.Exception("password not correct");
            }

            return first;
        }
    }
}