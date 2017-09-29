using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolRegistry.Models
{
    public class Student
    {
        public int ID { get; set; }

        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [StringLength(30)]
        [Required]
        public string Course { get; set; }

        public int Age { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthdate { get; set; }
    }
}
