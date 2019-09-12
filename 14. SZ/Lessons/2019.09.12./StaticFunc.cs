using System;

namespace StaticFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2.: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: {0}", SumOfNums(a, b));
        }

        static int SumOfNums(int a, int b)
        {
            return (a+b);
        }
    }
}
