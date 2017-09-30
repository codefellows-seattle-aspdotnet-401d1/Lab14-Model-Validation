using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab14George.Models
{
    public class Student
    {
        public int ID { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Required]
        //[Range(18,99, ErrorMessage ="A valid age is required.")]
        public int Age { get; set; }
        //[Required]
        public string Course { get; set; }
    }
}
