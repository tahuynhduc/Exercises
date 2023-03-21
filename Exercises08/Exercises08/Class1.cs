using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises08
{
    class GenericList<T>
    {
        //Khai báo mảng
        T[] data;
        //biến vị trí
        int position;
        //Constructor khởi tạo số phần tử
        public GenericList(int n)
        {
            data = new T[n];
            position = 0;
        }
        //phương thức thêm 1 phần tử
        public void Add(T item)
        {
            if (position < data.Length)
            {
                data[position] = item;
                position++;
            }
        }
        //phương thức xóa 1 phần tử
        public void Remove(T item)
        {
            int index = Array.IndexOf<T>(data, item, 0);
            if (index < position && index >= 0)
            {
                for (int i = index; i < position - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                position--;
            }
            else
            {
                Console.WriteLine("\'" + item + "\' not found");
            }
        }
        //phương thức hiển thị các phần tử
        public void Display()
        {
            for (int i = 0; i < position; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
