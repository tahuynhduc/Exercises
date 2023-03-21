using Excercises;

namespace Excercises04
{
    class program
    {
        static void Main(string[] args)
        {
            //bai 4.1
            //Khởi tạo lớp windows
            Window win = new Window(1, 2);
            //Khởi tạo lớp listbox
            ListBox lb = new ListBox(3, 4, "Stand alone list box");
            //khởi tạo lớp button
            Button b = new Button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();
            //khởi tạo mảng windows
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new ListBox(3, 4, "List box in array");
            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }

            //bai 4.2
            //khởi tạo sinh viên cao đẳng và in ra thông tin
            Console.WriteLine("Student of College:");
            StudentCollege sv1 = new StudentCollege("Hanh", 1992, 9.5, 8, 7);
            sv1.Display();
            Console.WriteLine("Average of score: {0}", sv1.Average());
            //khởi tạo sinh viên đại học và in ra thông tin
            Console.WriteLine("Student of University:");
            StudentUniversity sv2 = new StudentUniversity("Thanh", 1990, 6, 8, 7, 9);
            sv2.Display();
            Console.WriteLine("Average of score: {0}", sv2.Average());

            //bai 4.3
            //Khởi tạo hình chữ nhật
            Rectangle rec = new Rectangle();
            //nhập dữ liệu
            rec.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh chu nhat la:{0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chu nhat la:{0:N}", rec.Circumference());
            //Khởi tạo hình tròn
            Circle cir = new Circle();
            //nhập dữ liệu
            cir.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh tron la:{0:N}", cir.Area());
            Console.WriteLine("Chu vi hinh tron la:{0:N}", cir.Circumference());

            // bai 4.4
            //Tạo một nhân viên
            IPerson staff = new Staff();
            object data = "Bach Khoa Aptech";
            //gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            //tạo sinh viên
            IPerson student = new StuDent(){ Id = "S10", Name = "CHUNGLD",Age = 20};
            //hiển thị dữ liệu
            student.Display(student);

            //bai 4.5
            // create a Car object
            Car myCar = new Car();
            // call myCar.Start()
            Console.WriteLine("Calling myCar.Start()");
            myCar.Start();
            // call myCar.TurnLeft()
            Console.WriteLine("Calling myCar.TurnLeft()");
            myCar.TurnLeft();
            // call myCar.Accelerate()
            Console.WriteLine("Calling myCar.Accelerate()");
            myCar.Accelerate();
            Console.ReadLine();
        }
    }
}