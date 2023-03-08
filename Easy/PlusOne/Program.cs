namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nums = { 1,2,3 }, res= { };
            res=PlusOne(nums);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static int[] PlusOne(int[] digits)
        {
            var l = digits;

            int[] res = new int[l.Length+1];
            for (int i = 0; i < l.Length; i++)
            {
                res[i+1] = l[i];
            }

            for (int i = l.Length; i > 0; i--)
            {
                if (res[i]==9)
                {
                    res[i] = 0;
                    if (res[i - 1] < 9)
                    {
                        res[i - 1]++;
                        if (res.First() == 0)
                        {
                            for (int k = 1; k < res.Length; k++)
                            {
                                l[k - 1] = res[k];
                            }
                            return l;
                        }
                        return res;
                    }
                }
                else
                {
                    l[i-1]++;
                    return l;
                }        
            }
    
            return res;
        }
    }
}