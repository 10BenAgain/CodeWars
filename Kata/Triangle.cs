using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Triangle
    {
        /// <summary>
        ///  Implement a function that accepts 3 integer values a, b, c. 
        ///  The function should return true if a triangle can be built with the sides of given length and false in any other case.
        ///  (In this case, all triangles must have surface greater than 0 to be accepted)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                var s = (a + b + c) / 2;
                var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                if (area > 1)
                    return true;
            }
            return false;
        }
    }
}
