using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class ArraySorter
    {
        public static string[] SortByLength(string[] array)
        {
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
            return array;
        }
        public static string[] BetterSortByLength(string[] array) => array.OrderBy(e => e.Length).ToArray();

        public static int[] DataReverse(int[] data)
        {
            var blockSize = 8;
            var blocks = data.Length / blockSize;
            var startIndex = data.Length;
            var newStartIndex = 0;

            var outputArray = new int[data.Length]; 
            for (int i = blocks; i > 0; i--)
            {
                Array.Copy(data, startIndex - blockSize, outputArray, newStartIndex, 8);
                blockSize += 8;
                newStartIndex += 8;
            }
            return outputArray;
        }
        // Uses Linq - From CodeWars
        public static int[] BetterDataReverse(int[] data)
            => data.Chunk(8).Reverse().SelectMany(i => i).ToArray();

        public static int[] NoOdds(int[] values)
        {
            var returnArray = new int[values.Length];

            for (int i = 0; i <= values.Length - 1; i++)
            {
                if (values[i] % 2 == 0)
                {
                    returnArray[i] = values[i];
                }
            }

            return returnArray;
        }
        public static int[] BetterNoOdds(int[] values) => values.Where(x => x % 2 == 0).ToArray();
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x)
                .Where(group => group.Count() == 1)
                .Select(group => group.Key)
                .FirstOrDefault();
        }

        // too much brain power required for this 6 kyu today
        public static int[] PartsSums(int[] ls)
        {
            var returnList = new List<int>();
            var firstElement = 0;

            for (int i = 0; i <= ls.Length - 1; i++)
            {
                for (int j = ls.Length - i - 1; j > 1; j--)
                {
                    firstElement += ls[j];
                }
                returnList.Add(firstElement);
            }
            return returnList.ToArray();
        }
                
    }
}
