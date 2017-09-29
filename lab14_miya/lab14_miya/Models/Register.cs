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
        [Required]
        public string Name
        {
            get; set;
        }
        public int Age
        {
            get; set;
        }
        public int Grade
        {
            get; set;
        }
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
