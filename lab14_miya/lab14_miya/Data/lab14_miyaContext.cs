using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace lab14_miya.Models
{
    public class lab14_miyaContext : DbContext
    {
        public lab14_miyaContext (DbContextOptions<lab14_miyaContext> options)
            : base(options)
        {
        }

        public DbSet<lab14_miya.Models.Register> Register { get; set; }
    }
}
