using Exercises10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercises10.program;

namespace Exercises10
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public string City { get; set; }
        //Ghi đè phương thức ToString trả về thông tin chi tiết
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", EmpId, EmpName, Salary, City);
        }
    }
    
}
