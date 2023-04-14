using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Leet
{
    public class Easy
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        ///You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            var table = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (table.ContainsKey(nums[i]))
                    return new int[] { table[nums[i]], i };
                else
                {
                    table[target - nums[i]] = i;
                }
            }

            return new int[] { };
        }
    }
}
