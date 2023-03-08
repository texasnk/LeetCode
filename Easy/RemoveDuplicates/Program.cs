namespace RemoveDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 1, 2, 3, 3, 3, 5, 5, 6 };

            int res = RemoveDuplicates(nums);

            Console.WriteLine(res);

            Console.ReadKey();
        }
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return 1;

            int index1 = 0,
                index2 = 1;

            while (index2 <= nums.Length - 1)
                if (nums[index1] == nums[index2])
                    index2++;
                else
                    nums[++index1] = nums[index2++];

            return ++index1;
        }
    }
}