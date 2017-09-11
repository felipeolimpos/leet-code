namespace LeetCode
{
    public partial class Program
    {
        public void SortColors(int[] nums)
        {
            nums = elementToEnd(nums, 2, -1);
            nums = elementToEnd(nums, 1, 2);
        }

        public int[] elementToEnd(int[] nums, int element, int skip)
        {
            int current = 0;
            int elements = 0;

            while ((current + elements) < nums.Length)
            {
                if (nums[current].Equals(element))
                {
                    int indexToExchange = nums.Length - elements - 1;
                    if (nums[indexToExchange].Equals(element) || (skip >= 0 && nums[indexToExchange].Equals(skip)))
                    {
                        elements++;
                        continue;
                    }

                    nums[current] = nums[indexToExchange];
                    nums[indexToExchange] = element;
                    elements++;
                }

                current++;
            }

            return nums;
        }
    }
}