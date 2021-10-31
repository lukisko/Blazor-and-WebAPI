using WebAPI.Model;

namespace WebAPI.Data
{
    public interface IUserService
    {
         User ValidateUser(string userName, string Password);
    }
}