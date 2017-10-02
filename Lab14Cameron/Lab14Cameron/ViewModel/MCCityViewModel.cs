using Lab14Cameron.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab14Cameron.ViewModel
{
    public class MCCityViewModel
    {
        public List<Register> mcs ;
        public SelectList cities;
        public string mcCity { get; set; }
    }
}
