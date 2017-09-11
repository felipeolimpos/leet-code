namespace LeetCode
{
    public partial class Program
    {
        public int RemoveElement(int[] nums, int val)
        {
            int remaining = nums.Length;
            for (int i = nums.Length - 1; i >= 0; i--)
                if (nums[i].Equals(val))
                {
                    remaining--;
                    nums[i] = nums[remaining];
                }
            return remaining;
        }
    }
}