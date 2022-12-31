using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F(1);
            //Numbers(5);
            //Numbers_down(5);
            //revese_digit(3528);
            //convert_to_base(244, 2);
            //char[] arr = {'a', 'b', 'c', 'd', 'e', 'f'};
            //print_array(arr, 0);
            //string str = "Hello my world";
            //Rev_Word(str, 0);
            //string str = "1234567";
            //From_middle(str, 0, str.Length-1);
            //string numbers = Numbers1(4);
            //Console.WriteLine(numbers);
            //Console.WriteLine(Numbers2(9));
            Console.WriteLine(factorial(10));
            //Console.WriteLine(sigma(12));
            //Console.WriteLine(Arithmetic_series(3));
            //Console.WriteLine(print_series(5));
            //Console.WriteLine(sum_series(3));
            //prime(4200, 2);
            //Console.WriteLine(sum_digit(3527));
            //Console.WriteLine(multiply(7,4));
            //Console.WriteLine(Exp(2, 8));
            //Console.WriteLine(sum_digit_bigger(3527, 4));
            //Console.WriteLine(count_digit(35789));
            //Console.WriteLine(count_digit_small(35700));
            //Console.WriteLine(isPalindrome("abcddcba"));


            Console.WriteLine();
        }
        public static void F(int a)
        {
            if(a == 4)
            {
                Console.WriteLine("stop");
            } 
            else
            {
                Console.WriteLine(a);
                F(a + 1);
            }
            
        }

        public static void F1(int a)
        {
            if (a == 4)
            {
                Console.WriteLine("stop");
                return;
            }
            F1(a + 1);
            Console.WriteLine(a);
        }

        public static void Numbers(int n)
        {
            if (n == 0)
                return;

            Numbers(n - 1);
            Console.WriteLine(n);
        }

        public static void Numbers_down(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(n);
            Numbers_down(n - 1);
            
        }
        public static void Numbers_up_down(int n)
        {
            if (n == 0)
                return;

            Console.WriteLine(n);
            Numbers_down(n - 1);
            Console.WriteLine(n);
        }
        public static void revese_digit (int num)
        {
            if (num < 10)
            {
                Console.Write(num);
                return;
            }
            Console.Write(num % 10);
            revese_digit(num / 10);
            
        }

        public static void convert_to_base(int num, int b)
        {
            if (num == 0)
                return;

            convert_to_base(num / b, b);
            Console.Write(num % b);

        }
        public static void print_array (char [] arr, int i)
        {
            if (i == arr.Length)
                return;
            print_array(arr, i + 1);
            Console.WriteLine(arr[i]);
        }

        public static void Rev_Word (string str, int i)
        {
            if (str[i] == ' ')
                return;
            Rev_Word(str, i + 1);
            Console.WriteLine(str[i]);
        }

        public static void From_middle(string str, int i, int j)
        {
            if (i == j)
            {
                Console.Write(str[i]);
            }
            else
            {
                From_middle(str, i + 1, j - 1);
                Console.Write("" + str[i] + str[j]);
            }
        }

        public static string Numbers1 (int n)
        {
            if (n == 1)
                return "" + n;

            string ret = Numbers1(n - 1);
            return n + ret;
        }


        public static string Numbers2(int n)
        {
            if (n == 1)
                return "" + n;

            return n + Numbers2(n - 1);
        }

        public static int factorial(int n)
        {
            if (n == 1)
                return n;
            int result = factorial(n - 1);
            
            Console.WriteLine(result);
            return result * n;

        }

        public static int sigma (int n)
        {
            if (n == 1)
                return n;
            return n + sigma (n - 1);
        }

        public static double Arithmetic_series (int n)
        {
            if (n == 1)
                return 2; // a_1 = 2

            return 2.5 + Arithmetic_series(n - 1); // d = 2.5
        }

        public static double print_series(int n)
        {
            if (n == 1)
            {
                return 2; // a_1 = 2
            }

            double res = print_series(n - 1);
            Console.WriteLine(res);
            return 2.5 + res; // d = 2.5
        }

        public static double series(int n, double a_1, double q)
        {
            if (n == 1)
                return a_1; 

            return q * series(n - 1, a_1, q);
        }

        public static double write_series(int n, double a_1, double q)
        {
            if (n == 1)
            {
                return a_1; 
            }

            double res = write_series(n - 1, a_1, q);
            Console.WriteLine(res);
            return q * res;
        }

        public static void prime (int n, int i) // i = 2
        {
            if (n == 1)
                return;

            if (n % i == 0)
            {
                prime(n / i, i);
                Console.WriteLine(i);
            } 
            else
            {
                prime(n, i + 1);
            }
        }

        public static int sum_digit (int n)
        {
            if (n < 10)
                return n;

            return n % 10 + sum_digit(n / 10);            
        }

        public static int multiply(int m1, int m2)
        {
            if (m2 == 1)
                return m1;

            return m1 + multiply(m1, m2 - 1);
        }

        public static int Exp (int num, int power)
        {
            if (power == 1)
                return num;

            return num * Exp(num, power - 1);
        }

        public static int sum_digit_bigger(int n , int b)
        {
            if (n < 10)
                if (n >= b)
                    return n;
                else
                    return 0;

            if (n % 10 >= b)
                return n % 10 + sum_digit_bigger(n / 10, b);
            else 
                return sum_digit_bigger(n / 10, b);
        }

        public static int count_digit (int n)
        {
            if (n == 0)
                return 0;

            return 1 + count_digit(n / 10);
        }

        public static int count_digit_small(int n)
        {
            if (n == 0)
                return 0;

            if (n % 10 < 5)
                return 1 + count_digit_small(n / 10);
            else
                return count_digit_small(n / 10);
        }

        public static Boolean isPalindrome (string str)
        {
            if (str.Length < 2)
                return true;
                        
            return (str[0] == str[str.Length-1]) && isPalindrome(str.Substring(1,str.Length-2));
        }

    }
}
