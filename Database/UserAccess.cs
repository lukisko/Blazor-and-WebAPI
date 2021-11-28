using Entities.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Database
{
    public class UserAccess : Entities.Model.IUserService
    {
        public async Task<User> ValidateUser(string userName, string Password){
            using NewAdultContext adultContext = new NewAdultContext();
            User usr = await adultContext.Users.FirstAsync((user) => user.UserName == userName && user.Password == Password);
            return usr;
        }

        public async Task addUser(User newUser){
            using NewAdultContext dbContext = new NewAdultContext();
            await dbContext.AddAsync(newUser);
            await dbContext.SaveChangesAsync();
        }
    }
}