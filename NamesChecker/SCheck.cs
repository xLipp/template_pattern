using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesChecker
{
    public class SCheck
    {
        public static bool nametemp(string tname)
        {
            if (tname.Length >20 ||tname.Length<19 ) return false;       
            if (!tname.All(Char.IsDigit)) return false;
            if (tname.Intersect(".:").Count() == 0) return true;
            return true;
        }

    }
}
