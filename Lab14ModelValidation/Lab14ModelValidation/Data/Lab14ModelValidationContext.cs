using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab14ModelValidation.Models
{
    public class Lab14ModelValidationContext : DbContext
    {
        public Lab14ModelValidationContext (DbContextOptions<Lab14ModelValidationContext> options)
            : base(options)
        {
        }

        public DbSet<Lab14ModelValidation.Models.Student> Student { get; set; }
    }
}
