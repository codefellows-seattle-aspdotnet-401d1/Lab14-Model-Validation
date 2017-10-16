using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab14George.Models
{
    public class Lab14GeorgeContext : DbContext
    {
        public Lab14GeorgeContext (DbContextOptions<Lab14GeorgeContext> options)
            : base(options)
        {
        }

        public DbSet<Lab14George.Models.Register> Register { get; set; }
    }
}
