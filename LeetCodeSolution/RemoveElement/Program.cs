namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums = { 3, 2, 2, 3 };
            int res = RemoveElement(nums, 3);

            Console.WriteLine(res);

            Console.ReadKey();
        }

        public static int RemoveElement(int[] nums, int val)
        {
            if(nums== null || nums.Length == 0) return 0;
            

            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                while (i < nums.Length && nums[i] == val)
                    i++;

                if (i < nums.Length)
                    nums[k++] = nums[i];
            }

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            return k;
        }
    }
}