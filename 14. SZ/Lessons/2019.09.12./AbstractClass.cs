using System;
using System.Collections.Generic;

namespace AbstractClass
{
    abstract class Base
    {
        public virtual void Subtract(List<int> l){}

        public virtual int Sum(List<int> l){return 0;}
    }

    class Calculate : Base
    {
        public override void Subtract(List<int> l)
        {
            if(l[0]>=l[l.Count-1])
            {
                Console.WriteLine("Result: {0}", l[0]-(l[l.Count-1]));
            }
            else
            {
                Console.WriteLine("Result: {0}", (l[l.Count-1])-l[0]);
            }
        }

        public override int Sum(List<int> l)
        {
            int result = 0;
            for (int i = 0; i < l.Count; ++i)
            {
                result += l[i];
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            List<int> l = new List<int>();
            Console.Write("Mennyi számot szeretnél?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                Console.Write("{0}.: ", i+1);
                l.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Kivonás");
            calc.Subtract(l);
            Console.WriteLine("Összeadás");
            Console.WriteLine("Result: {0}", calc.Sum(l));
        }
    }
}
