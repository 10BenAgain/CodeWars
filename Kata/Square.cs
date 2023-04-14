using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Square
    {
        public static bool IsSquare(int n)
        {
            return (n % Math.Sqrt(n) == 0 || n == 0);
        }

        public static bool BetterSquareCheck(int n)
        {
            return Math.Sqrt(n) % 1 == 0;
        }
    }
}
