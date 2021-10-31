using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPI.Model;
using System.Text.Json;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private IAdultData data;
        public AdultsController(IAdultData data){
            this.data = data;
        }

        [HttpGet]
        public ActionResult<IList<Adult>> GetAdults(){
            //Console.WriteLine(data.GetAdults().Count);
            var jsonList = JsonSerializer.Serialize(data.GetAdults());
            return StatusCode(200,jsonList);//TODO change
        }

        [HttpPut("{id}")]
        public ActionResult<Adult> UpdateAdult(int id, Adult adult){
            Console.WriteLine("update start");
            try {
                //Adult adult = JsonSerializer.Deserialize<Adult>(adultIn);
                this.data.UpdateAdult(adult);
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
        public ActionResult<Adult> RemoveAdult([FromRoute] int id){
            try {
                var tempAdult = this.data.GetAdults().Where((adult2)=> adult2.Id == id);
                this.data.RemoveAdult(id);
                return StatusCode(200,tempAdult);
            } catch (Exception e){
                return StatusCode(500,e.Message);
            }
        }
    }
}