using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    abstract class Shape
    {
        protected float radius, length, width;
        //Khai báo các phương thức trừu tượng
        public abstract float Area();//tính diện tích
        public abstract float Circumference();//tính chu vi
    }
    class Circle : Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.Write("Nhap ban kinh:");
            radius = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return 3.14F * radius * radius;
        }
        //ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * 3.14F * radius;
        }
    }
    class Rectangle : Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.Write("Nhap chieu dai:");
            length = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong:");
            width = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return length * width;
        }
        //ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * (length + width);
        }
    }
}
