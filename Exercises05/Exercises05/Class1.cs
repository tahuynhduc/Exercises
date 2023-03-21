using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises05
{
    class Product
    {
        //Khai báo trường và thuộc tính theo cách thông thường
        private int id;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        //Khai báo thuộc tính tự động
        public double Price { get; set; }
        public double Quantity { get; set; }
        //Khai báo thuộc tính chỉ ghi
        private int discount;
        public int Discount { set { discount = value; } }
        //Khai báo thuộc tính chỉ đọc
        private double total;
        public double Total { get { return Price * Quantity - discount; } }
    }
}
