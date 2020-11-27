using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKulesiEF
{
    public static class Utilities
    {
        public static string Virgulle(this IEnumerable<string> kaynak)
        {
            return string.Join(", ", kaynak);
        }
    }
}
