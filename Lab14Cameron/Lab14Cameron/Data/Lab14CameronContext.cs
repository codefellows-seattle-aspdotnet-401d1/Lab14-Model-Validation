using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab14Cameron.Models
{
    public class Lab14CameronContext : DbContext
    {
        public Lab14CameronContext (DbContextOptions<Lab14CameronContext> options)
            : base(options)
        {
        }

        public DbSet<Lab14Cameron.Models.Register> Register { get; set; }
    }
}
