using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab14Validation.Models
{
    public class lab14ValidationContext : DbContext
    {
        public lab14ValidationContext (DbContextOptions<lab14ValidationContext> options)
            : base(options)
        {
        }

        public DbSet<lab14Validation.Models.Students> Students { get; set; }
    }
}
