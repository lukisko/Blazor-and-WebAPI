using Model;
using System.Threading.Tasks;

namespace assignment.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string Password);
    }
}