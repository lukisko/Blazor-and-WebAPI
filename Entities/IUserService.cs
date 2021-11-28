using System.Threading.Tasks;

namespace Entities.Model
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string Password);
        Task addUser(User newUser);
    }
}