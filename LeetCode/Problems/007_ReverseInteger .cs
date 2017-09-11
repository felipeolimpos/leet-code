using System;

namespace LeetCode
{
    public partial class Program
    {
        public int Reverse(int x)
        {
            var isNegative = x < 0;
            if (isNegative) x *= -1;

            var s = x.ToString();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            s = new string(charArray);

            try
            {
                int result = Convert.ToInt32(s);
                if (isNegative) result *= -1;
                return result;
            }
            catch { }

            return 0;
        }
    }
}