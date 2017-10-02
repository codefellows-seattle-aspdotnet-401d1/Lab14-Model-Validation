using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab14Cameron.Models
{
    public class Register
    {
        public int ID { get; set; }
        [Required]
        public string MC { get; set; }
        [Required]
        [Display(Name = "CITY")]
        public string Hometown { get; set; }
        [Required]
        [Display(Name = "STATE")]
        public string HomeState { get; set; }
        [Required]
        [Display(Name = "ALBUMS")]
        public int Albums { get; set; }
        [Display(Name = "1st ALBUM")]
        public string FirstAlbumTitle { get; set; }
        [Display(Name = "DEBUT")]
        [DataType(DataType.Date)]
        public DateTime FirstAlbum { get; set; }


    }
}
