using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    abstract class Student
    {
        protected string name;
        protected int year;
        // Phương thức khởi tạo
        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        // phương thức hiển thị thông tin
        protected void Display()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Year: {0}", year);
        }
        //phương thức tính điểm trung bình
        public abstract double Average();
    }
    class StudentCollege : Student
    {
        protected double score1, score2, score3;
        //constructor
        public StudentCollege(string name, int year, double score1, double
        score2, double score3) : base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }
        //ghi đè phương thức tính trung bình điểm
        public override double Average()
        {
            return (score1 + score2 + score3) / 3;
        }
        //hiển thị thông tin
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score 1: {0:N}", score1);
            Console.WriteLine("Score 2: {0:N}", score2);
            Console.WriteLine("Score 3: {0:N}", score3);
        }
    }
    class StudentUniversity : StudentCollege
    {
        protected double score4;
        //constructor
        public StudentUniversity(string name, int year, double score1, double
        score2, double score3, double score4)
        : base(name, year, score1, score2, score3)
        {
            this.score4 = score4;
        }
        //phương thức tính trung bình điểm
        public override double Average()
        {
            return (score1 + score2 + score3 + score4) / 4;
        }
        // phương thức hiển thị thông tin
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score 4: {0:N}", score4);
        }
    }
}
