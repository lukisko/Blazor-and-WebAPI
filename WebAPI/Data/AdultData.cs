using WebAPI.Model;
using System.Collections.Generic;
using WebAPI.Persistance;
using System.Linq;
using System;
using System.Threading.Tasks;
using Entities.Model;

namespace WebAPI.Data
{
    public class AdultData : Entities.Model.IAdultData
    {
        //private IList<Adult> adults;
        private FileContext file;
        public AdultData(){
            file = new FileContext();
        }
        public async Task<IList<Adult>> GetAdults(){
            List<Adult> tmp = new List<Adult>(file.Adults);
            //Console.WriteLine(tmp.Count);
            return tmp;
        }
        public async Task<Adult> AddAdult(Adult adult){
            adult.Id = this.GetMaxIndex() + 1;
            file.Adults.Add(adult);
            file.SaveChanges();
            return adult;
        }
        public async Task UpdateAdult(Adult adult){
            Console.WriteLine("update in adult data");
            Adult toUpdate = file.Adults.First(a => a.Id.Equals(adult.Id));
            if (toUpdate == null){
                return;
            } else {
                file.Adults.Remove(toUpdate);
                file.Adults.Add(adult);
            }
            
            file.SaveChanges();
        }
        public async Task RemoveAdult(int personId){
            Adult toRemove = file.Adults.First(a => a.Id.Equals(personId));
            file.Adults.Remove(toRemove);
            file.SaveChanges();
        }

        private int GetMaxIndex(){
            return file.Adults.Max(adul => adul.Id);
        }
    }
}