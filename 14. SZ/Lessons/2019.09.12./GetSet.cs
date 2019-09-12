using System;

namespace GetSet
{
    class Example
    {
        private int a = 10;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            //e.a nem elérhető a private védelme miatt
            Console.WriteLine(e.A);
            e.A=15; //felülírható 
            Console.WriteLine(e.A);
        }
    }
}
