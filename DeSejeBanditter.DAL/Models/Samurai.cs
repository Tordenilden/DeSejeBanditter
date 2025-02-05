using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSejeBanditter.DAL.Models
{
    /// <summary>
    /// EF (Entity Framework)
    /// PK => className + Id (Id, id, ID...) eller id
    /// Package Manager COnsole => Husk at vælge det rigtige project
    /// <InvariantGlobalization>false</InvariantGlobalization> inde i project filen , står til true
    /// </summary>
    public class Samurai // Type
    {
        //[Key()] // PK
        public int SamuraiId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // 1 - 1 choose which Model that has the FK 
        public int HouseId { get; set; } // FK
        public House House { get; set; } // Navigation property - den kommer ikke ned i DB
    }
}
