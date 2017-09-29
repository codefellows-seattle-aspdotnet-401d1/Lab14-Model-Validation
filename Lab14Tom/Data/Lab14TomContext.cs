using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab14Tom.Models
{
    public class Lab14TomContext : DbContext
    {
        public Lab14TomContext (DbContextOptions<Lab14TomContext> options)
            : base(options)
        {
        }

        public DbSet<Lab14Tom.Models.Register> Register { get; set; }
    }
}
