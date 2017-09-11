using System;
using Hashtable = System.Collections.Generic.Dictionary<object, object>;

namespace LeetCode
{
    public partial class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var map = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (map.ContainsKey(nums[i]))
                {
                    return new int[] { (int)map[nums[i]], i };
                }

                if (!map.ContainsKey(complement))
                {
                    map.Add(complement, i);
                }
            }

            throw new Exception("Not possible!");
        }
    }
}