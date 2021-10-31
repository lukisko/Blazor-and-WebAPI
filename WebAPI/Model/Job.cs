using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public class Job
    {
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}