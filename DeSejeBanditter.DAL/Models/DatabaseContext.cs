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
        public DbSet<House> House { get; set; }
        // 1) create Model
        // 2) if there is a Relation (kig i House) create it
        // 3) create a DbSet<ModelName>

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
