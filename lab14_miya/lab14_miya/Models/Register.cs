using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab14_miya.Models
{
    public class Register
    {
        public int ID
        {
            get; set;
        }
        [StringLength(30, MinimumLength =1)]
        [Required]
        public string Name
        {
            get; set;
        }
        [Range(1,130)]
        [Required]
        public int Age
        {
            get; set;
        }
        [Range(1,12)]
        public int Grade
        {
            get; set;
        }
        [StringLength(30)]
        public string Talent
        {
            get; set;
        }
        [Display(Name="Favorite Subject")]
        public string FavoriteClass
        {
            get; set;
        }
    }
}
