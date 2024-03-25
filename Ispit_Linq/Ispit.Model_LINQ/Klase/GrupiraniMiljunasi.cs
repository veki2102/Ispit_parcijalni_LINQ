using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Model_LINQ.Klase
{
    internal class GrupiraniMiljunasi:Klijent
    {
        public string Banka { get; set; }
        public IEnumerable<string> Miljunasi { get; set; }

    }
}
