using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Recursion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F1(1);
            //Numbers(5);
            //Numbers_down(5);
            //revese_digit(3528);
            //convert_to_base(244, 2);
            //char[] arr = {'a', 'b', 'c', 'd', 'e', 'f'};
            //print_array(arr, 0);
            //string str = "Hello my world";
            //Rev_Word(str, 0);
            //Rev_Word2(str);
            //string str = "1234567";
            //From_middle(str, 0, str.Length-1);
            //Console.WriteLine(isExponent(17));
            //Console.WriteLine(log_2(129, 0));

            //string[] arr = { "alef", "Bet", "Cammel", "Caa" };
            //Console.WriteLine(IsAlphabetOrdered(arr,0));
            //double[] arr = { 5, 12, 21, 2 };
            //Console.WriteLine(sum_divide_small1(arr,0,0)); 
            //string numbers = Numbers1(4);
            //Console.WriteLine(numbers);
            //Console.WriteLine(Numbers2(9));
            //Console.WriteLine(factorial(10));
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
            //double[] arr = { -2.1, 0, 1.5, 3.2, 5.5, 12};
            //Console.WriteLine(is_sort_exists(arr,3.2, 0, arr.Length-1));

            //Combination_string1(3, "");
            //Fibunachi_series(11);

            int[] arr = { 23, 310, 29, 12, 113, 34, 57 };
            Console.WriteLine(foo(arr, 0, arr.Length - 1));
            
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
            Console.WriteLine(a);
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

        /*****************************************/

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

        public static void Rev_Word2(string str)
        {
            if (str[0] == ' ')
                return;
            Rev_Word2(str.Substring(1));
            Console.WriteLine(str[0]);
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

        public static void isPalyndrom(string str, int i, int j)
        {
            if (j - i < 2)
                Console.Write("Polyndrom");

            if (str[i] != str[j])
            {
                Console.Write("Not Polyndrom");
            }

            isPalyndrom(str, i + 1, j - 1);
        }

        public static void isPalyndrom2(string str)
        {
            if (str.Length < 2)
                Console.Write("Polyndrom");

            if (str[0] != str[str.Length-1])
            {
                Console.Write("Not Polyndrom");
            }

            isPalyndrom2(str.Substring(1, str.Length - 2));
        }


        /*****************************************/

        public static bool isExponent (int n)
        {
            if (n == 1)
                return true;
            if (n % 2 != 0)
                return false;

            return isExponent(n / 2);
        }

        public static int log_2(int n, int exp)
        {
            if (n == 1)
                return exp;
            if (n % 2 != 0)
                return -1;

            return log_2(n / 2, exp+1);
        }

        public static bool IsExist (int[] arr, int n, int i)
        {
            if (i == arr.Length)
                return false;

            if (arr[i] == n)
                return true;

            return IsExist(arr, n, i+1);
        }

        public static int Find (int[] arr, int n, int i)
        {
            if (i == arr.Length)
                return -1;

            if (arr[i] == n)
                return i;

            return Find(arr, n, i + 1);
        }

        public static bool IsAlphabetOrdered (string[] arr, int i)
        {
            if (i == arr.Length-1)
                return true;

            if (arr[i].CompareTo(arr[i+1]) > 0)
                return false;

            return IsAlphabetOrdered(arr, i + 1);
        }

        public static double ArrSum(double[] arr, int i, double sum)
        {
            if (i == arr.Length-1)
                return sum;
                        
            return ArrSum(arr, i+ 1, sum + arr[i]);
        }

        public static int Count_even (int[] arr, int i, int count)
        {
            if (i == arr.Length-1)
                return count;

            if (arr[i] % 2 == 0)
                count++;

            return Count_even (arr, i+1, count);
        }

        public static int Sigma(int num, int sum)
        {
            if (num == 0)
                return sum;
            
            return Sigma (num-1, sum += num);
        }

        public static int Factorial(int num, int result)        // init result = 1
        {
            if (num == 1)
                return result;

            return Factorial(num - 1, result *= num);
        }

        public static double Arr_max (double[] arr, int i, double max)  // init max = arr[0]
        {
            if (i == arr.Length-1)
                return max;

            if (arr[i] > max)
                max = arr[i];

            return Arr_max(arr, i+1, max);

        }

        public static double Find_min(double[] arr, int i, double min, int min_index)  // init min = arr[0]; min_index = 0
        {
            if (i == arr.Length - 1)
                return min_index;

            if (arr[i] < min)
            {
                min = arr[i];
                min_index = i;
            }

            return Find_min(arr, i + 1, min, min_index);

        }



        /*****************************************/

        public static int Count_digits (int num)
        {
            if (num < 10)
                return 1;

            return Count_digits(num/ 10) + 1;
        }

        public static int Count_digits1(int num)
        {
            if (num < 10)
                return 1;
            
            int count = Count_digits1(num / 10);
            return  count + 1;
        }

        public static int count_odds(int[] arr, int i)
        {
            if (i == arr.Length - 1)
                return 0;

            int count = count_odds(arr, i + 1);

            if (arr[i] % 2 != 0)
                return count + 1;
            return count;
        }

        public static int count_odds1 (int[] arr, int i)
        {
            if (i == arr.Length - 1)
                return 0;

            if (arr[i] % 2 != 0)
                return count_odds1 (arr, i+1) + 1;
            return count_odds1 (arr, i + 1);
        }

        /*****************************************/


        public static int factorial(int n)
        {
            if (n == 1)
                return n;
            int result = factorial(n - 1);
            return result * n;

        }
        public static int factorial1 (int n)
        {
            if (n == 1)
                return n;
            return factorial1 (n - 1) * n;
        }

        public static int sigma(int n)
        {
            if (n == 1)
                return n;
            return n + sigma(n - 1);
        }


        public static double sum_divide_small(double[] arr, int i, double sum)
        {
            if (i == arr.Length)
                return sum;

            sum += arr[i];
            double res = sum_divide_small (arr, i+1, sum); 
            if (arr[i] < 10)
                return res / arr[i];
            return res;
        }

        public static double sum_divide_small1(double[] arr, int i, double sum)
        {
            if (i == arr.Length)
                return sum;

            if (arr[i] < 10)
                return sum_divide_small1(arr, i + 1, sum += arr[i]) / arr[i];

            return sum_divide_small1(arr, i + 1, sum += arr[i]);
        }
        
        public static double Arithmetic_series(int n)
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

        public static int multiply(int m1, int m2)
        {
            if (m2 == 1)
                return m1;

            return m1 + multiply(m1, m2 - 1);
        }

        public static int Exp(int num, int power)
        {
            if (power == 1)
                return num;

            return num * Exp(num, power - 1);
        }

        /*****************************************/

        public static bool is_exists_positive(double[] arr, int i)
        {
            if (i == arr.Length)
                return false;
            
            return is_exists_positive(arr, i+1) || arr[i] > 0;
        }

        public static bool is_all_positive (double[] arr, int i)
        {
            if (i == arr.Length)
                return true;

            return is_all_positive (arr, i + 1) && arr[i] > 0;
        }

        public static Boolean isPalyndrom(string str)
        {
            if (str.Length < 2)
                return true;

            return isPalyndrom(str.Substring(1, str.Length - 2)) && str[0] == str[str.Length - 1]; 
        }
        
        public static Boolean isPalyndrom1 (string str)
        {
            if (str.Length < 2)
                return true;

            bool res = isPalyndrom1(str.Substring(1, str.Length - 2));
            return  res && str[0] == str[str.Length - 1];
        }

        /*****************************************/
        public static double smallest (double[] arr, int i)
        {
            if (i == arr.Length-1)
                return arr[i];

            return Math.Min(smallest (arr, i + 1), arr[i]);
        }

        /*****************************************/

        public static bool is_sort_exists (double[] arr, double num, int i, int j)
        {
            if (i > j)
                return false;

            int k = (i + j) / 2;
            if (arr[k] == num)
                return true;
            else if (num < arr[k])
                return is_sort_exists(arr, num, i, k - 1);
            else
                return is_sort_exists(arr, num, k + 1, j);
        }

        public static int find_sort(double[] arr, double num, int i, int j)
        {
            if (i > j)
                return -1;

            int k = (i + j) / 2;
            if (arr[k] == num)
                return k;
            else if (num < arr[k])
                return find_sort(arr, num, i, k - 1);
            else
                return find_sort(arr, num, k + 1, j);
        }

        public static void prime_dividres(int n, int divider) // divider = 2
        {
            if (n == 1)
                return;

            if (n % divider == 0)
            {
                prime_dividres(n / divider, divider);
                Console.WriteLine(divider);
            }
            else
            {
                prime_dividres(n, divider + 1);
            }
        }


        public static bool is_valid (string str, int count)
        {
            if (str.Length == 0)
                if (count == 0)         // סןגריים מאוזנים
                    return true;
                else                    // סוגריים לא מאוזנים
                    return false;

            if (str[0] == '(')             // אם סוגריים פותחות תתקדם ברשימה ותוסיף 1 למספור
                return is_valid(str.Substring(1), count+1);

            if (str[0] == ')' && count == 0) // אם הסוגריים סוגרות ואין סוגריים פותחות - תחזיר שקר
                return false;
            if (str[0] == ')')                 // אם סוגריים סוגרות תחסיר אחד ממספר הסוגריים ותתקדם ברשימה.
                return is_valid(str.Substring(1), count - 1);

            return is_valid(str.Substring(1), count);    // אם לא סוגריים כלל - תתקדם ברשימה מבלי לשנות את מספר הסוגריים
        }



        /*****************************************/


        public static void Combination_string(int n, string st)  // n - מספר התווים במחרוזת הסופית
        {
            if (n == 0)
            {
                Console.WriteLine(st);
                return;
            }
            Combination_string (n - 1, st + "a");
            Combination_string (n - 1, st + "b");
        }

        public static void Combination_string1(int n, string st)  // n - מספר התווים במחרוזת הסופית
        {
            if (n == 0)
            {
                Console.WriteLine(st);
                return;
            }
            Console.WriteLine(st);
            Combination_string1 (n - 1, st + "a");
            Combination_string1 (n - 1, st + "b");
        }


        public static int count_Comb (int n, string st)  // n - מספר התווים במחרוזת הסופית
        {
            if (n == 0)
                return 1;
            
            return count_Comb (n - 1, st + "a") + count_Comb (n - 1, st + "b");
        }
        
        public static int count_Comb_2 (int n, string st)  // n - מספר התווים במחרוזת הסופית
        {
            if (n == 0)
                return 1;

            return 1 + count_Comb_2 (n - 1, st + "a") + count_Comb_2 (n - 1, st + "b");
        }

        public static int Fibunachi (int n)
        {
            if (n == 0)
                return 0;
            if (n== 1)
                return 1;

            return Fibunachi(n - 1) + Fibunachi(n - 2);
        }

        public static void Fibunachi_series(int n, int a = 0, int b = 1)
        {
            if (n == 1)
            {
                Console.Write(a);
                return;
            }
            Console.Write(a + ", ");                
            Fibunachi_series(n - 1, b, a+b);
        }

        public static int Fibunachi_item(int n, int a = 0, int b = 1)
        {
            if (n == 1)
                return a;

            return Fibunachi_item(n - 1, b, a + b);
        }

        public static int minOps (int x, int y)
        {
            if (x > y)                  // חרגנו מהיעד - נחזיר אין סוף
                return int.MinValue;
            if (x == y)                 // הגענו ליעד נחזיר 0 פעולות
                return 0;
            int a = minOps(x+1, y);     // נבדוק פעולת חיבור
            int b = minOps(x*2, y);     // נבדוק פעולת כפל
            return 1 + Math.Min(a, b);  // נחזיר את מינימום בין מספר הפעולות שקיבלנו + הפעולה הנוכחית

        }

        public static bool sumPair (double[] arr, int num, int i, int j)
        {
            if (i == j)
                return false;
            if (arr[i] + arr[j] == num)
                return true;
            return sumPair(arr, num, i+1, j) || sumPair(arr,num, i, j+1);
        }

        public static bool hasSum (double[] arr, double num, int i, double sum)
        {
            if (sum == num)
                return true;
            if (sum > num)
                return false;
            if (i == arr.Length)
                return false;

            return hasSum(arr, num, i + 1, sum + arr[i] ) || hasSum(arr, num, i + 1, sum);
        }

        public static bool hasSum_2(double[] arr, double num, int i, double sum)
        {
            if (sum == num)
                return true;
            if (sum > num)
                return false;
            if (i == arr.Length)
                return false;

            return hasSum_2(arr, num, i , sum + arr[i]) || hasSum_2(arr, num, i + 1, sum);
        }


        public static bool path_exists(int[][] mat, int row, int col, int end_row, int end_col)
        {
            if (row == end_row && col == end_col) // הגענו לסיום
                return true;
            if (row < 0 || col < 0 || row == mat.Length || col == mat[0].Length) // יצאנו מגבולות המטריצה
                return false;
            if (mat[row][col] == 0) // נתקלמו בקיר
                return false;
            if (mat[row][col] == -1)    // כבר ביקרנו במקום
                return false;

            mat[row][col] = -1;         // סמן כמקום שביקרנו

            return path_exists(mat, row + 1, col, end_row, end_col)  ||
                path_exists(mat, row - 1, col, end_row, end_col)     ||
                path_exists(mat, row, col + 1, end_row, end_col)     ||
                path_exists(mat, row, col - 1, end_row, end_col);
        }


        public static int min_path(int[][] mat, int row, int col, int end_row, int end_col, int length)
        {
            if (row == end_row && col == end_col) // הגענו לסיום
                return length;
            if (row < 0 || col < 0 || row == mat.Length || col == mat[0].Length) // יצאנו מגבולות המטריצה
                return int.MaxValue;
            if (mat[row][col] == 0) // נתקלמו בקיר
                return int.MaxValue;
            if (mat[row][col] == -1)    // כבר ביקרנו במקום
                return int.MaxValue;

            mat[row][col] = -1;         // סמן כמקום שביקרנו

            return Math.Min(min_path(mat, row + 1, col, end_row, end_col, length + 1), 
                Math.Min(min_path(mat, row - 1, col, end_row, end_col, length + 1),
                Math.Min(min_path(mat, row, col + 1, end_row, end_col, length + 1),
                min_path(mat, row, col - 1, end_row, end_col, length + 1))));
        }


        public static int min_path(int[][] mat, int row, int col, int end_row, int end_col)
        {
            if (row == end_row && col == end_col) // הגענו לסיום
                return 0;
            if (row < 0 || col < 0 || row == mat.Length || col == mat[0].Length) // יצאנו מגבולות המטריצה
                return int.MaxValue;
            if (mat[row][col] == 0) // נתקלמו בקיר
                return int.MaxValue;
            if (mat[row][col] == -1)    // כבר ביקרנו במקום
                return int.MaxValue;

            mat[row][col] = -1;         // סמן כמקום שביקרנו

            return 1 + Math.Min(min_path(mat, row + 1, col, end_row, end_col),
                Math.Min(min_path(mat, row - 1, col, end_row, end_col),
                Math.Min(min_path(mat, row, col + 1, end_row, end_col),
                min_path(mat, row, col - 1, end_row, end_col))));
        }


        /*****************************************/

        public static int foo(int[] arr, int i, int j)
        {
            if (i == j)
                return arr[i];
            int k = i + j / 2;
            return Math.Max(foo(arr, i, k), foo(arr, k + 1, j));
        }

        




        public static void slice()
        {
            string str = "Hello World";
            Console.Write(str.Substring(2, str.Length-2));
        }
        

    }
}
