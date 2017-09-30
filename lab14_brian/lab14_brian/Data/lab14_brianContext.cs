using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab14_brian.Models
{
    public class lab14_brianContext : DbContext
    {
        public lab14_brianContext (DbContextOptions<lab14_brianContext> options)
            : base(options)
        {
        }

        public DbSet<lab14_brian.Models.Dinosaurs> Dinosaurs { get; set; }
    }
}
