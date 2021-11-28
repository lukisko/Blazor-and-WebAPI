using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Model;
using System.Text.Json;
using Entities.Model;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private Entities.Model.IAdultData data;
        public AdultsController(Entities.Model.IAdultData data){
            this.data = data;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults(){
            //Console.WriteLine(data.GetAdults().Count);
            IList<Adult> adultList = await data.GetAdults();
            var jsonList = JsonSerializer.Serialize(adultList);
            return StatusCode(200,jsonList);//TODO change
        }

        [HttpPut("{id}")]
        public ActionResult<Adult> UpdateAdult(int id, Adult adult){
            Console.WriteLine("update start");
            try {
                //Adult adult = JsonSerializer.Deserialize<Adult>(adultIn);
                this.data.UpdateAdult(adult);
                Console.WriteLine("epdate ends.");
                return StatusCode(200);
            } catch (Exception e){
                Console.WriteLine(e.Message);
                return StatusCode(500);
            }
        }

        [HttpPost]
        public ActionResult<Adult> AddAdult(Adult adult){
            try {
                //Adult adult = JsonSerializer.Deserialize<Adult>(adultIn);
                data.AddAdult(adult);
                return StatusCode(200,adult);
            } catch (Exception e){
                return StatusCode(500,e.Message);
            }
            
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> RemoveAdult([FromRoute] int id){
            try {
                var tempAdult1 =await this.data.GetAdults();
                Console.WriteLine(this.data +"\n"+tempAdult1);
                var tempAdult = tempAdult1.Where((adult2)=> adult2.Id == id);
                Console.WriteLine("here");
                await this.data.RemoveAdult(id);
                Console.WriteLine("here2");
                return StatusCode(200,tempAdult);
            } catch (Exception e){
                return StatusCode(500,e);
            }
        }
    }
}