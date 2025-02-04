using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSejeBanditter.DAL.Models
{
    /// <summary>
    /// all examples is calling it context - 90%
    /// </summary>
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DatabaseContext()
        {
            
        }
        public DbSet<Samurai> Samurai { get; set; } // this is a table, named Samurai, PK SamuraiId

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
