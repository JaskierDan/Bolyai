using System;

namespace ClassFunc
{
    class Calculate
    {
        public int Sum(int a, int b)
        {
            return (a+b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            Console.Write("1.: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2.: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: {0}", calc.Sum(a, b));
        }
    }
}
