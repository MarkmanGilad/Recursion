using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "ABCD";
            int n = str.Length;
            Sod(str, 0, n - 1);
        }

        private static void Sod (String str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    Sod (str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }

        public static String swap (String str,int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();   // change a string to char array
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);       // change char array to string
            return s;
        }


    }
}
