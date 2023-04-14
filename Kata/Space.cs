using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Space
    {
        public static string NoSpace(string input)
        {
            var returnString = "";

            foreach (var s in input.Split(" "))
                returnString += s;

            return returnString;
        }
        public static string BetterNoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
