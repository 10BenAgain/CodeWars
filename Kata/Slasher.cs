using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Slasher
    {
        public static int CircleSlash(int n)
        {
            return (n - (1 << 31 - (32 - Convert.ToString(n, 2).Length))) * 2 + 1;
        }
    }
}
