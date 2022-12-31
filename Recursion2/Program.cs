using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] arr = { 5, 10 };
            Console.WriteLine("main head " + arr[0]);
            F1(arr);
            Console.WriteLine("main bottom " + arr[0]);

        }

        public static void F1(int [] arr)
        {
            Console.WriteLine("F1 head " + arr[0]);
            arr[0]++;
            F2(arr);
            Console.WriteLine("F1 bottom " + arr[0]);
        }

        public static void F2(int [] arr)
        {
            Console.WriteLine("F2 head " + arr[0]);
            arr[0]++;
            Console.WriteLine("F2 bottom " + arr[0]);
        }

    }
}
