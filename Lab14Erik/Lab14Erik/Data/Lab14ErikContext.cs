using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab14Erik.Models
{
    public class Lab14ErikContext : DbContext
    {
        public Lab14ErikContext (DbContextOptions<Lab14ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab14Erik.Models.Student> Student { get; set; }
    }
}
