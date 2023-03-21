using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises05
{
    //tạo namespace kinh doanh
    namespace Business
    {
        //lớp nhà ở
        public class House
        {
            public string HouseNo { get; set; }
            public decimal Price { get; set; }
        }
        //tạo namespace con đại lý lồng bên trong namespace kinh doan
        namespace Dealership
        {
            //tạo lớp xe
            public class Car
            {
                public string CarNo { get; set; }
                public decimal Price { get; set; }
            }
        }
    }
}
