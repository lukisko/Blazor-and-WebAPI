using System.Collections.Generic;

namespace WebAPI.Model
{
    public interface IAdultData
    {
        IList<Adult> GetAdults();
        Adult AddAdult(Adult adult);
        void UpdateAdult(Adult adult);//to add parametres
        void RemoveAdult(int personId);
    }
}