using DeSejeBanditter.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeSejeBanditter.DAL.Interfaces
{
    public interface ISamurai
    {
        // return all samurais
        public List<Samurai> GetSamurais();
    }
}
