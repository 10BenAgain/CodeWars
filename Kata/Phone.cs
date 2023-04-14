using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Phone
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            var checkedList = new List<int>();

            if (numbers.Length == 10)
                for (int i = 0; i < 10; i++)
                {
                    if (numbers[i] > 9 && numbers[i] > 0)
                        break;
                    else
                        checkedList.Add(numbers[i]);
                }

            string phoneNumber = "";
            foreach (var i in checkedList)
                phoneNumber += Convert.ToString(i);
            
            return String.Format("({0}) {1}-{2}", phoneNumber.Substring(0, 3), phoneNumber.Substring(3, 3), phoneNumber.Substring(6));
        }

        // Code war solution
        public static string BetterNumber(int[] numbers)
        {
            return String.Format("{0:(000) 000-0000}", ulong.Parse(String.Join("", numbers)));
        }

        public static string IsItANum(string str)
        {
            return str;
        }

        public static bool ValidPhoneNumber(string phoneNumber)
        {
            var numberArr = phoneNumber.Split("");

            if (Convert.ToChar(numberArr[0]) != '(' && Convert.ToChar(numberArr[4]) != ')') { return false; }
            
            return true;
        }
    }
}
