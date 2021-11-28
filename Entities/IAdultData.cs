using System.Collections.Generic;
using System.Threading.Tasks;

namespace Entities.Model
{
    public interface IAdultData
    {
         Task<IList<Adult>> GetAdults();
        Task<Adult> AddAdult(Adult adult);
        Task UpdateAdult(Adult adult);//to add parametres
        Task RemoveAdult(int personId);
    }
}