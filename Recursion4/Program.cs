using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F (1);
        }
        public static void F (int a)
        {
            Console.WriteLine(a);
            F(a + 1);
        }

    }
}
