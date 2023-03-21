using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisis6
{
    //định nghĩa delegate
    delegate void FunctionToCall();
    //định nghĩa lớp
    class MyClass
    {
        //định nghĩa phương thức không tĩnh
        public void nonStaticMethod()
        {
            Console.WriteLine("Non Static Method");
        }
        //định nghĩa phương thức tĩnh
        public static void staticMethod()
        {
            Console.WriteLine("Static Method");
        }
    }
}
