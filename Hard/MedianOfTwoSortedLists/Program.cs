using System.Xml.Linq;

namespace MedianOfTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] nums1 = { 1,2 }, nums2 = { 3,4 };
            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));

            Console.ReadKey();


        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] res = new int[0];
            int j=0, k=0;

            while (j<nums1.Length && k < nums2.Length)
            {
                if (nums1[j] <= nums2[k])
                {
                    res=res.Append(nums1[j]).ToArray();
                    j++;
                }
                else
                {
                    res = res.Append(nums2[k]).ToArray();
                    k++;
                }

            }

            while (j < nums1.Length)
            {
                res = res.Append(nums1[j]).ToArray();
                j++;
            }
            while (k < nums2.Length)
            {
                res = res.Append(nums2[k]).ToArray();
                k++;
            }

            int mid;
            mid = res.Length / 2;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            if (res.Length % 2 != 0) return res[mid];
            else
            {
                return (double)(res[mid] + res[mid - 1])/2;
            }
        }
    }
}