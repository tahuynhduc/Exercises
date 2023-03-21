using Exercises03;

namespace exercises03
{
    class program
    {
        static void Main(string[] args)
        {
            //bai 3.1
            //khai báo và khởi tạo mảng 1 chiều
            int[] m = { 5, 8, 3, 0, 2, 1, 7, 8 };
            //duyệt mảng và in dữ liệu
            Console.Write("Cac phan tu cua mang:");
            for (int i = 0; i < m.Length; i++)
            {
                Console.Write(" {0} ", m[i]);
            }
            //tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 0; i < m.Length; i++)
            {
                if (max < m[i])
                    max = m[i];

            }
            Console.WriteLine("\nPhan tu lon nhat:" + max);
            //kiểm tra mảng có đối xứng không?
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++)
            {
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");

            // bai 3.2
            int[,] a ={
                    {4,6,9},
                    {2,4,5},
                    {9,2,6},
                    {1,6,3}
             };
            //duyệt mảng và in theo hàng cột
            Console.WriteLine("Noi dung mang:");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    Console.Write(" {0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            //tìm các phần tử có chỉ số hàng bằng chỉ số cột
            Console.WriteLine("Cac phan tu co chi so hang bang chi so cot:");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (i == j)
                        Console.Write(" {0} ", a[i, j]);
                }
            }
            //các phần tử lớn nhất trên hàng
            Console.WriteLine("Cac phan tu lon nhat tren hang");
            for (int i = 0; i <= a.GetUpperBound(0); i++)
            {
                int mxa = a[i, 0];
                for (int j = 0; j <= a.GetUpperBound(1); j++)
                {
                    if (mxa < a[i, j])
                        mxa = a[i, j];

                }
                Console.WriteLine("Hang {0}:{1}", i, mxa);
            }

            // bai 3.3
            // tạo đối tượng Car
            Car myCar = new Car();
            // gán giá trị cho các trường của đối tượng
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.year = 1995;
            //hiển thị thông tin về đối tượng myCar
            System.Console.WriteLine("Thong tin chi tiet:");
            System.Console.WriteLine("Make: " + myCar.make);
            System.Console.WriteLine("Model: " + myCar.model);
            System.Console.WriteLine("Color: " + myCar.color);
            System.Console.WriteLine("Year release: " + myCar.year);
            // gọi các phương thức
            myCar.Start();
            myCar.Stop();

            // bai 3.4
            //tạo đối tượng contact với constructor không tham số
            Contact ct1 = new Contact();
            //gán giá trị cho ct1
            ct1.Id = 6;
            ct1.FirstName = "Nguyen Thi";
            ct1.LastName = "Hoa";
            ct1.Address = "Ha Noi";
            ct1.Phone = "0978735922";
            ct1.Email = "hoahoa@gmail.com";
            //tạo đối tượng contact với constructor có tham số
            Contact ct2 = new Contact(5, "Tran Thi", "Tinh", "Tuyen Quang",
            "0987874555", "bupbecotinhyeu@yahoo.com");
            //hiển thị thông tin ct1 và ct2
            ct1.Display();
            ct2.Display();

            // bai 3.5
            //tạo đối tượng
            StudentModel action = new StudentModel();
            //gọi phương thức lấy tất cả sinh viên
            List<Student> listall = action.GetStudent();
            //hiển thị
            foreach (var item in listall)
            {
                item.Display();
            }
            //gọi phương thức lấy sinh viên theo id
            Student st = action.GetStudent(2);
            //hiển thị
            st.Display();
            //gọi phương thức lấy sinh viên có tuổi từ 25-30
            List<Student> listage = action.GetStudent(25, 30);
            //hiển thị
            foreach (var item in listage)
            {
                item.Display();
            }

            // bai 3.6
            int a = 20, b = 30;
            double area;
            Utility u = new Utility();
            Console.WriteLine("Truoc khi hoan vi a={0},b={1}", a, b);
            u.SwapFake(a, b);
            Console.WriteLine("Sau khi hoan vi dang fake a={0},b={1}", a, b);
            u.SwapReally(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi dang really a={0},b={1}", a, b);
            u.AreaCircle(100, out area);
            Console.WriteLine("Chu vi hinh tron ban kinh 100 la: {0}", area);
        }
    }
}