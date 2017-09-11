using System;

namespace LeetCode
{
    public partial class Program
    {
        public int HammingWeight(uint n)
        {
            var s = Convert.ToString(n, 2);
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Equals('1'))
                    result++;
            }

            return result;
        }
    }
}