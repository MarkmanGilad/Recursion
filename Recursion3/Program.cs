using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char [] arr = { 'a', 'b', 'c', 'd', 'e', 'f'};
            int i=0 , j = 5;
            F1(arr, i + 1, j - 1);
            Console.WriteLine("" + arr[i] + arr[j]);
        }

        public static void F1(char [] arr, int i, int j)
        {
            F2 (arr, i + 1, j - 1);
            Console.Write("" + arr[i]  + arr[j]);
        }

        public static void F2(char[] arr, int i, int j)
        {
            Console.Write("" + arr[i] + arr[j]);
        }

    }
}
