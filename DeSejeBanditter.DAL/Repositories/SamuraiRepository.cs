using DeSejeBanditter.DAL.Interfaces;
using DeSejeBanditter.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSejeBanditter.DAL.Repositories
{
    /// <summary>
    /// Install Packages
    /// Create a Context class (our handle to DB)
    /// </summary>
    public class SamuraiRepository : ISamurai
    {
        // Hvordan tilgår vi så vores databae?
        // hvad hvis jeg vil generer et objekt af Samurai??
        DatabaseContext context { get; set; }
        public SamuraiRepository(DatabaseContext c)
        {
            context = c;
        }
        public List<Samurai> GetSamurais()
        {
            return context.Samurai.ToList();
        }
    }
}

//context.Samurai.FirstOrDefault((x) => x.SamuraiId == 1);
//Samurai s = new Samurai();
//s.Name = "hansi";
//string name = s.Name;
//DatabaseContext context = new DatabaseContext();
//context.Samurai.LINQ

//throw new NotImplementedException();