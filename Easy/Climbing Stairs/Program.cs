using System.Numerics;

namespace Climbing_Stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(ClimbStairs(5));

            Console.ReadKey();

        }
        public static int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            int[] dp = new int[n+1];

            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
                dp[i] = dp[i - 1] + dp[i - 2];

            return dp[n];
        }
    }
}
