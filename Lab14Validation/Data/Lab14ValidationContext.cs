using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab14Validation.Models
{
    public class Lab14ValidationContext : DbContext
    {
        public Lab14ValidationContext (DbContextOptions<Lab14ValidationContext> options)
            : base(options)
        {
        }

        public DbSet<Lab14Validation.Models.StudentModel> StudentModel { get; set; }
    }
}
