using System.Collections.Generic;
using System.Threading.Tasks;
using Entities.Model;

namespace WebAPI.Model
{
    public interface IAdultData
    {
        Task<IList<Adult>> GetAdults();
        Task<Adult> AddAdult(Adult adult);
        Task UpdateAdult(Adult adult);//to add parametres
        Task RemoveAdult(int personId);
    }
}