using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class IPConvert
    {
        public static uint ToInt32(string ip)
        {
            var splitter = ip.Split('.');
            var ipToString = string.Empty;

            for (int i = 0; i <= splitter.Length - 1; i++)
            {
                var strToInt = Convert.ToInt32(splitter[i]);
                ipToString += Convert.ToString(strToInt, 2);
            }

            return Convert.ToUInt32(ipToString, 2);
        }
        public static string FromInt32(int sec) => Convert.ToString(sec, 2);

        // From CodeWars Solutions, I like it because no Linq. For now
        public static uint BetterToInt32(string ip)
        {
            uint number = 0;
            ip += ".0"; 
            for (byte i = 0; i < 4; i++)
            {
                byte octet = Convert.ToByte(ip.Substring(0, ip.IndexOf('.')));
                ip = ip.Substring(ip.IndexOf('.') + 1);
                number = (number << 8) + octet;
            }
            return number;
        }
    }
}
