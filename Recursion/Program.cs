using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("main head " + a);
            F1(a + 1);
            Console.WriteLine("main bottom " + a);

        }

        public static void F1 (int a)
        {
            Console.WriteLine("F1 head " + a);
            a++;
            F2 (a + 1);
            Console.WriteLine("F1 bottom " + a);
        }

        public static void F2 (int a)
        {
            Console.WriteLine("F2 head " + a);
            a++;
            Console.WriteLine("F2 bottom " + a);
        }
    }
}
