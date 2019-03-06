using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Database
{
    public class SchoolDatabase : DbContext
    {
        public SchoolDatabase(DbContextOptions<SchoolDatabase> options) : base(options)         
        {         
        }
        
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set;  }
    }
}