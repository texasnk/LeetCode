namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(MySqrt(17785));

            Console.ReadKey();
        }
        public static int MySqrt(int x)
        {
            if (x == 0)
                return x;
            int first = 1, last = x;
            while (first <= last)
            {
                int mid = first + (last - first) / 2;

                if (mid == x / mid)
                    return mid;
                else if (mid > x / mid)
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
            }
            return last;
        }
    }
}