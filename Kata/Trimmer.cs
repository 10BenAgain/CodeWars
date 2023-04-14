using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Trimmer
    {
        public static string TrimString(string phrase, int len)
        {
            if (phrase.Length <= len)
                return phrase;
            else
            {
                var stringDot = phrase + "...";
                var returnString = $"{stringDot.Substring(0, len)}...";
                return $"{stringDot.Substring(0, len)}...";
            }
                
        }
    }
}
