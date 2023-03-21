using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises08
{
    //Định nghĩa giao diện Generic
    interface ICaluclator<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Div(T a, T b);
        T Mul(T a, T b);
    }
    //Định nghĩa lớp thực thi giao diện từ Generic
    class CalculatorInt : ICaluclator<int>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
