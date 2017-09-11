namespace LeetCode
{
    public partial class Program
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var result = string.Empty;

            if (strs.Length <= 1)
            {
                if (strs.Length.Equals(0))
                {
                    return result;
                }
                return strs[0];
            }

            for (int size = 0; size < strs[0].Length; size++)
            {
                for (int b = 1; b < strs.Length; b++)
                {
                    if (strs[b].IndexOf(strs[0].Substring(0, size + 1)) != 0) break;

                    if (b.Equals(strs.Length - 1)) result = strs[0].Substring(0, size + 1);
                }
            }

            return result;
        }
    }
}