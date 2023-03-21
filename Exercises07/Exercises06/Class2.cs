using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises06
{
    class Student : IComparable<Student>
    {
        //khai báo các thuộc tính tự động
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public double Avg { get; set; }
        //ghi đè phương thức tostring
        public override string ToString()
        {
            return "\nId:" + Id + "\nFullName:" + FirstName + " " + LastName
            + "\nGender:" + (Gender ? "Male" : "Female") + "\nAverage mark:" +
            Avg;
        }
        //thực thi phương thức CompareTo và so sánh tuổi để sắp xếp tăng dần,nếu sắp xếp giảm dần thì đảo lại đối tượng là xong
        public int CompareTo(Student other)
        {
            return this.Avg.CompareTo(other.Avg);
        }


    }
}