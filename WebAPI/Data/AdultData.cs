using WebAPI.Model;
using System.Collections.Generic;
using WebAPI.Persistance;
using System.Linq;
using System;

namespace WebAPI.Data
{
    public class AdultData : IAdultData
    {
        //private IList<Adult> adults;
        private FileContext file;
        public AdultData(){
            file = new FileContext();
        }
        public IList<Adult> GetAdults(){
            List<Adult> tmp = new List<Adult>(file.Adults);
            //Console.WriteLine(tmp.Count);
            return tmp;
        }
        public Adult AddAdult(Adult adult){
            adult.Id = this.GetMaxIndex() + 1;
            file.Adults.Add(adult);
            file.SaveChanges();
            return adult;
        }
        public void UpdateAdult(Adult adult){
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
        public void RemoveAdult(int personId){
            Adult toRemove = file.Adults.First(a => a.Id.Equals(personId));
            file.Adults.Remove(toRemove);
            file.SaveChanges();
        }

        private int GetMaxIndex(){
            return file.Adults.Max(adul => adul.Id);
        }
    }
}