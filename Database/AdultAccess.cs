using Entities.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Database
{
    public class AdultAccess : Entities.Model.IAdultData
    {
        public AdultAccess(){
            //do nothing
        }
        public async Task<IList<Adult>> GetAdults(){
            using NewAdultContext dbContext = new NewAdultContext();
            /*Adult adl = new Adult() {
                Id = 1,
                FirstName = "Lukas",
                LastName = "Pleva",
            };
            await dbContext.Adult.AddAsync(adl);
            await dbContext.SaveChangesAsync();*/
            //Console.WriteLine(await dbContext.Test.ToListAsync());
            return await dbContext.Adults.Include(ad => ad.JobTitle).ToListAsync();
        }
        public async Task<Adult> AddAdult(Adult adult){
            using NewAdultContext dbContext = new NewAdultContext();
            EntityEntry<Adult> newlyAdded= await dbContext.AddAsync(adult);
            await dbContext.SaveChangesAsync();
            return newlyAdded.Entity;
        }
        public async Task UpdateAdult(Adult adult){
            try {
                using NewAdultContext dbContext = new NewAdultContext();
                Adult toUpdate = await dbContext.Adults.Include((adl) => adl.JobTitle).FirstAsync((adl) => adl.Id == adult.Id);
                //adult.Id = toUpdate.Id;
                toUpdate.FirstName = adult.FirstName;
                toUpdate.LastName = adult.LastName;
                toUpdate.Age = adult.Age;
                toUpdate.EyeColor = adult.EyeColor;
                toUpdate.HairColor=adult.HairColor;
                toUpdate.Height = adult.Height;
                toUpdate.JobTitle = adult.JobTitle;
                toUpdate.Sex = adult.Sex;
                toUpdate.Weight = adult.Weight;

                Console.WriteLine("new first name: "+toUpdate.FirstName);
                dbContext.Update(toUpdate);
                await dbContext.SaveChangesAsync();
                return;
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find adult with id{adult.Id}");
            }
        }
        public async Task RemoveAdult(int personId){
            try {
                using NewAdultContext dbContext = new NewAdultContext();
                var adultsToRemove = dbContext.Adults.Where(adult => adult.Id == personId);
                dbContext.RemoveRange(adultsToRemove);
                await dbContext.SaveChangesAsync();
            } catch (Exception e){
                Console.WriteLine(e);
                return;
            }
        }
    }
}