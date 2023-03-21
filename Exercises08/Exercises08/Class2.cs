using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises08
{

    //Định nghĩa lớp
    public class MathEx
    {
        //Phương thức Generic tìm phần tử lớn nhất trong một mảng
        public static T Max<T>(T first, params T[] values) where T : IComparable
        {
            T maximum = first;
            foreach (T item in values)
            {
                if (item.CompareTo(maximum) > 0)
                {
                    maximum = item;
                }
            }
            return maximum;
        }
        //Phương thức Generic tìm phần tử nhỏ nhất trong một mảng
        public static T Min<T>(T first, params T[] values) where T : IComparable
        {
            T minimum = first;
            foreach (T item in values)
            {
                if (item.CompareTo(minimum) < 0)
                {
                    minimum = item;
                }
            }
            return minimum;
        }
    }
}
