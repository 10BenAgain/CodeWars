using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class PowerTwo
    {
        public static bool PowerOfTwo(int n)
        {
            if (n % 2 != 0 || n == 1) { return false; }
        
            for (int i = n; i >= 2; i--)
            {
                if (n == 2) { break; }
                n /= 2;
            }
            return n == 2;
        }
        // Codewars Solution
        public static bool BetterPowerOfTwo(int n) => Math.Log2(n) % 1 == 0;

    }
}
