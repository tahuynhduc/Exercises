using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisis6
{
    //định nghĩa lớp custom ngoại lệ chỉ cho nhập số nguyên dương
    public class InvalidInputNumber : Exception
    {
        public InvalidInputNumber()
        : base("Hay nhap 1 so >0") { }
    }
}
