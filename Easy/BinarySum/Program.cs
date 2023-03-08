using System.Runtime.Intrinsics.Arm;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BinarySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(AddBinary("1111", "1111"));

            Console.ReadKey();
        }
        public static string AddBinary(string a, string b)
        {
            string res = "";
            char C = '0';
            
            if (a.Length > b.Length)
            {
                int i = 0;
                while (a.Length > b.Length)
                {
                    b = b.Insert(i, "0");
                    i++;
                }
            }
            else
            {
                int i = 0;
                while (b.Length > a.Length)
                {
                    a = a.Insert(i, "0");
                    i++;
                }
            }

            int size = a.Length;

            Console.WriteLine("A= " + a);
            Console.WriteLine("B= " + b);

            char A, B;
            for (int i = size-1; i >=0; i--)
            {
                A = a[i];
                B = b[i];

                if (A == '1' && B == '1')
                {
                    
                    if (C == '1')
                    {
                        res = res.Insert(0, "1");      
                    }
                    else
                    {
                        res = res.Insert(0, "0");
                        C = '1';
                    }
                   
                } else if (A == '0' && B == '0')
                {
                    if (C == '1')
                    {
                        res = res.Insert(0, "1");
                        C = '0';
                    }
                    else res = res.Insert(0, "0");
                } else if(A=='0'&&B=='1'|| A == '1' && B == '0')
                {
                    if (C == '1')
                    {
                        res = res.Insert(0, "0");
                    }
                    else res = res.Insert(0, "1");

                }

            }

            if (C=='1')
            {
                res = res.Insert(0, "1");
            }

            return "RES: "+res;
        }
    }
}