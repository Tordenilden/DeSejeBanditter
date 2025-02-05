using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSejeBanditter.DAL.Models
{
    //   Samurai M - 1  House  - Database relation (FK)
    //   1 Samurai har 1 Hus    - Set fra Samurai
    //   1 Hus har M Samurai    - Set fra House

    //   EF / C# => vender relation om Samurai 1-M House

    //   M - M (A - AB - B)
    public class House
    {
        public int HouseId { get; set; }
        public string Adress { get; set;}
        List<Samurai> Samurais { get; set; } = new List<Samurai>(); // this is our FK 
    }
}
