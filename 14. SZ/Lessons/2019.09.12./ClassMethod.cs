using System;

namespace ClassMethod
{
    class Calculate
    {
        public void Sum(int a, int b)
        {
            int c=a+b;
            Console.WriteLine("Result: {0}", c);
            //vagy
            //Console.WriteLine(a+=b);
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
            calc.Sum(a,b);
        }
    }
}
