using WebAPI.Model;
using Entities.Model;

namespace WebAPI.Data
{
    public interface IUserService
    {
         User ValidateUser(string userName, string Password);
    }
}