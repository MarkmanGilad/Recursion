using System;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace Rec_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool rec (BinNode<int> tr)
        {
            if (tr == null)
                return true;

            bool left = rec(tr.GetLeft());
            bool right = rec(tr.GetRight());
            bool current = tr.GetValue() == 5; // תנאי כלשהו
            return left && right && current;
        }

        public static bool rec_2 (BinNode<int> tr)
        {
            if (tr == null)
                return true;

            bool left = rec_2(tr.GetLeft());
            bool right = rec_2(tr.GetRight());
            bool current =  tr.HasLeft() && tr.GetValue() == tr.GetLeft().GetValue() ||
                            tr.HasRight() && tr.GetValue() == tr.GetRight().GetValue();      // תנאי כלשהו כולל בדיקה אם יש בן
            return left || right || current;
        }

        public static int rec_3 (BinNode<int> tr)
        {
            if (tr == null)
                return 0;
            if (!tr.HasLeft() && !tr.HasRight())    // לעיתים יש לעשות בדיקות מיוחדות אם יש עלה אן בן אחד
                return 0;

            int left = rec_3(tr.GetLeft());
            int right = rec_3(tr.GetRight());
            int current = tr.GetValue();

            return Math.Max(left, Math.Max(right, current));
            // return left + right + current
        }


        public static int rec_func (int param)
        {
            if (stop_condition)
            {
                return result;
            }
            do_something / calculate;

            return rec_func(param);

        }

    }
}
