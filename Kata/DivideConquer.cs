using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class DivideConquer
    {
        public static int DivCon(Object[] objArray)
        {
            int intCheck = 0;
            int intStrings = 0;

            foreach (object i in objArray)
            {
                _ = i is Int32 ?  intCheck += Convert.ToInt32(i) : intStrings += Convert.ToInt32(i);
            }

            return intCheck - intStrings;
        }
    }
}
