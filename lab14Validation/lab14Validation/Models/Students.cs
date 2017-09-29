using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab14Validation.Models
{
    public class Students
    {
        public int ID { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        public int Grade { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Display(Name = "GPA")]
        public float GradePntAvg { get; set; }

        [Display(Name = "Student ID")]
        [Required]
        public int StudentID { get; set; }
    }
}
