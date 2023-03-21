namespace Exercises08
{
    class program
    {
        static void Main(string[] args)
        {
            // bai 8.1
            //Khởi tạo collection 10 phần tử
            GenericList<string> students = new GenericList<string>(10);
            students.Add("Thinh");
            students.Add("Dung");
            students.Add("Hai");
            //hiển thị
            Console.WriteLine("Noi dung collection:");
            students.Display();
            //xóa phần tử
            students.Remove("Dung");
            //hiển thị
            Console.WriteLine("Noi dung collection sau khi xoa:");
            students.Display();

            //bai 8.2
            //sử dụng các phương thức Generic
            Console.WriteLine("Gia tri lon nhat:" + MathEx.Max<int>(7, 490, 56, 890, 45));
            Console.WriteLine("Gia tri nhonhat: "+MathEx.Min<string>("NewYork","LonDon","HaNoi" ,"Paris"));

            // bai 8.3
            //tạo đối tượng personalIdentification
            var std = new PersonalIdentification("James Sandt");
            std.DateofBirth = new DateTime(2002, 12, 8);
            //tạo đối tượng employee
            Employee<PersonalIdentification> empl = new
            Employee<PersonalIdentification>();
            //gán thuộc tính Identification của Employee choPersonal
            empl.Identification = std;
            //hiển thị thông tin
            Console.WriteLine("Full Name: {0}",
            empl.Identification.FullName);
            Console.WriteLine("Date Of birth: {0}",
            empl.Identification.DateofBirth.ToShortDateString());
            Console.WriteLine();

            //bai 8.4
            //Tạo đối tượng calculator
            CalculatorInt cal = new CalculatorInt();
            int a = 10, b = 5;
            //Test kết quả
            Console.WriteLine("{0}+{1}={2}", a, b, cal.Add(a, b));
            Console.WriteLine("{0}-{1}={2}", a, b, cal.Sub(a, b));
            Console.WriteLine("{0}*{1}={2}", a, b, cal.Mul(a, b));
            Console.WriteLine("{0}/{1}={2}", a, b, cal.Div(a, b));

            //bai 8.5
            //tạo đối tượng Department
            Department dep = new Department();
            //sử dung foreach truy xuất tập hợp
            foreach (string item in dep)
            {
                Console.WriteLine(item);
            }
            //tạo đối tượng Flower
            Flower f = new Flower();
            //dùng foreach duyệt qua tập hợp
            foreach (string item in f.GetFlower())
            {
                Console.WriteLine(item);
            }
        }
    }
}