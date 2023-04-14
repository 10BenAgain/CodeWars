using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class DotCalc
    {
        public static string Calculator(string txt)
        {

            if (txt.Contains('+'))
            {
                txt = new string('.', txt.Substring(0, txt.IndexOf('+') - 1).Length + txt.Substring(txt.IndexOf('+') + 2).Length);
            }
            else if (txt.Contains('-'))
            {
                txt = new string('.', txt.Substring(0, txt.IndexOf('-') - 1).Length - txt.Substring(txt.IndexOf('-') + 2).Length);
            }
            else if (txt.Contains('*'))
            {
                txt = new string('.', txt.Substring(0, txt.IndexOf('*') - 1).Length * txt.Substring(txt.IndexOf('*') + 2).Length);
            }
            else
            {
                txt = new string('.', txt.Substring(0, txt.IndexOf('/') - 1).Length / txt.Substring(txt.IndexOf('/') + 3).Length);
            }
            return txt;

        }

    }

}
