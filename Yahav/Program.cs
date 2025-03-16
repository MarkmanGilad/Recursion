using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F1(10);
        }
        public static void F1(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(n);
                return;
            }
            
            F1(n - 1);
            Console.WriteLine(n);

        }
    }
}
