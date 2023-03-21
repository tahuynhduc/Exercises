using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises09
{
    partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        //định nghĩa phươn thức thành phần Display
        partial void Display();
    }
    //Định nghĩa lớp thành phần Employee
    partial class Employee
    {
        //constructor khởi tạo
        public Employee()
        {
            this.Name = "Tran Hai Ha";
            this.Address = "Ha Noi";
            this.Id = 111;
            this.Age = 22;
        }
        //triển khai phương thức thành phần
        partial void Display()
        {
            Console.WriteLine("Ma so:" + Id);
            Console.WriteLine("Ho va ten:" + Name);
            Console.WriteLine("Dia chi:" + Address);
            Console.WriteLine("Tuoi:" + Age);
        }
        //định nghĩa phương thức gọi phương thức thành phần
        public void CallDisplay()
        {
            Display();
        }
    }
}
