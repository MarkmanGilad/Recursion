using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //Console.WriteLine("main head " + a);
            //F1(a + 1);
            //Console.WriteLine("main bottom " + a);
            //Console.WriteLine(findPassword("cbc", 3));
            Console.WriteLine(pass1("",3,"ccc"));

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
    
        // str = ""; c= 'a'; length = 5; password = the correct password
        public static string pass1 (string str, int length, string password)
        {
            if (length == 0)
            {
                Console.WriteLine(str);
                if (str == password)
                    return str;
                else
                    return "";
            }
            string temp = "";
            for (int i = 'a'; i<='z'; i++)
            {
                temp += pass1(str + (char)i, length - 1, password);
            }
            return temp;
        }

        public static string findPassword (string p, int length)
        {
            string password =  pass("", 'a', length, p);
            Console.WriteLine("****************");
            return password;
        }

        public static string pass(string str, char c, int length, string password)
        {
            if (length == 0)
            {
                Console.WriteLine(str);
                if (str == password)
                    return str;
                else
                    return "";
            }
            string temp = "";
            if (c <= 'z')
            {
                temp += pass(str + c, 'a', length - 1, password);
                temp += pass(str, (char)(c + 1), length, password);
            }
            return temp;
        }
    }
}
