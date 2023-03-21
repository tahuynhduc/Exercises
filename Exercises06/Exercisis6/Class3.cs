using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisis6
{
    //khai báo delegate
    public delegate void OddNumberFinder(int num);
    //định nghĩa lớp kiểm tra số lẻ
    class TestOdd
    {
        //khai báo sự kiện cho việc tìm thấy số lẻ
        public event OddNumberFinder OnOddNumber;
        //phương thức đếm số lẻ
        public void CountOdd()
        {
            int odd;
            for (odd = 1; odd < 50; odd += 2)
                //gọi sự kiện kiểm tra số lẻ
                OnOddNumber(odd);

        }
        //định nghĩa phương thức hiển thị số lẻ
        public void ShowOdd(int odd)
        {
            Console.WriteLine(odd);
            Console.WriteLine("Event Fired...");
        }
    }
}
