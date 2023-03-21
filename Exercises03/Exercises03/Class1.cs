using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises03
{
    class Car
    {
        // khai báo các trường với phạm vi public
        public string make;
        public string model;
        public string color;
        public int year;
        // định nghĩa phương thức start
        public void Start()
        {
            System.Console.WriteLine(model + " khoi dong");
        }
        // định nghĩa phương thức stop
        public void Stop()
        {
            System.Console.WriteLine(model + " dung");
        }
    }
}
