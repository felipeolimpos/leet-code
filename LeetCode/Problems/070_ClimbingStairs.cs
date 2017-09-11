using Hashtable = System.Collections.Generic.Dictionary<object, object>;

namespace LeetCode
{
    public partial class Program
    {
        public int ClimbStairs(int n)
        {
            return Fibonacci(n + 1);
        }

        private int Fibonacci(int n)
        {
            if (n <= 2) return 1;

            var seq = new Hashtable();

            seq.Add(1, 1);
            seq.Add(2, 1);

            for (int i = 2; i < n; i++)
            {
                seq.Add(i + 1, (int)seq[i] + (int)seq[i - 1]);
            }

            return (int)seq[n];
        }
    }
}