using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Model
{
    public class Job
    {
        public int Id {get;set;}
        public string JobTitle { get; set; }
        [Range(0,int.MaxValue)]
        public int Salary { get; set; }
    }
}