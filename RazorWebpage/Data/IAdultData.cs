using System.Collections.Generic;
using System.Threading.Tasks;

namespace Model
{
    public interface IAdultData
    {
        Task<IList<Adult>> GetAdults();
        Task AddAdult(Adult adult);
        Task UpdateAdult(Adult adult);//to add parametres
        Task RemoveAdult(int personId);
    }
}