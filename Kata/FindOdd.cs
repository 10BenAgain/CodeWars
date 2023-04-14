using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class FindOdd
    {
        public static int FindIt(int[] seq)
        {
            // Check if array only has one stored value
            if (seq.Length < 2) { return seq[0]; }

            Array.Sort(seq);
            var listOfSubs = new List<int>();

          

            return -1;
        }
    }
}
