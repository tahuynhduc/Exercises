using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    interface IPerson
    {
        //phương thức insert
        void Insert(object obj);
        //phương thức xóa
        void Delete(object obj);
        //phương thức sửa
        void Update(object obj);
        //phương thức hiển thị
        void Display(object obj);
    }
    //định nghĩa lớp nhân viên thực thi từ giao diện IPerson
    class Staff : IPerson
    {
        //thực thi các phương thức của giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);
        }

        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong: " + obj);
        }

        public void Display(object obj)
        {
            Console.WriteLine("Thong tin doi tuong: " + obj);
        }
    }
    //định nghĩa lớp sinh viên thực thi từ giao diện IPerson
    class StuDent : IPerson
    {
        //khai báo thuộc tính
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //thực thi các phương thức từ giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);
        }

        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong: " + obj);
        }

        public void Display(object obj)
        {
            StuDent st = (StuDent)obj;
            Console.WriteLine("Id:" + st.Id);
            Console.WriteLine("Name:" + st.Name);
            Console.WriteLine("Age:" + st.Age);
        }
    }
}
