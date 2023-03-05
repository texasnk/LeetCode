namespace LengthofLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(LengthOfLastWord("Hello, world! "));

            Console.ReadKey();
        }
        public static int LengthOfLastWord(string s)
        {
            s = s.TrimEnd(' ');
            Console.WriteLine(s.Remove(0,s.LastIndexOf(' ')+1).Count());

            return 1;
        }
    }
}