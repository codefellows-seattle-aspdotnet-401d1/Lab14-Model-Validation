using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab14_brian.Models
{
    public class Dinosaurs
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Carnivore?")]
        public bool IsCarnivore { get; set; }
    }
}
