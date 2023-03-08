namespace SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nums = { 1, 3, 5, 6 };
            int res = SearchInsert(nums, 5);


            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int k=0;
            if (nums.Length == 0) return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < target) k++;
            }

            return k;
        }
    }
}