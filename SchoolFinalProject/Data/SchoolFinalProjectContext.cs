using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolFinalProject.Models;

namespace SchoolFinalProject.Data
{
    public class SchoolFinalProjectContext : DbContext
    {
        public SchoolFinalProjectContext (DbContextOptions<SchoolFinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolFinalProject.Models.School> School { get; set; }

        public DbSet<SchoolFinalProject.Models.Tutor> Tutor { get; set; }

        public DbSet<SchoolFinalProject.Models.Student> Student { get; set; }
    }
}
