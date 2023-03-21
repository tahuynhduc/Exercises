namespace Exercises10
{
    //Khai báo delegate nhận 1 tham số nguyên
    delegate int MyDelegate1(int x);
    //Khai báo delegate nhận 2 tham số nguyên
    delegate int MyDelegate2(int x, int y);
    class program
    {
        public static int Calculate(MyDelegate2 Add, int x, int y)
        {
            int s = Add(x, y);
            return s;
        }
        public delegate bool EmpDelegate(Employee emp);
        static void Main(string[] args)
        {
            //bai 10.1
            //Sử dụng delegate tham chiếu tới phương thức cộng 2 số nguyên
            Func<int, int, int> sumNumber = Calculator.Add;
            //Sử dụng delegate tham chiếu tới phương thức nối 2 chuỗi
            Func<string, string, string> joinString = Calculator.Join;
            //In kết quả - gọi delegate
            Console.WriteLine(sumNumber(10, 30));
            Console.WriteLine(joinString("Ha Noi-", "Viet Nam"));

            //bai 10.2
            //biểu thức Lambda
            MyDelegate1 cube = x => x * x * x;
            //câu lệnh Lambda
            MyDelegate1 sum = x =>
            {
                int s = 0;
                for (int i = 1; i <= x; i++)
                {
                    s += i;
                }
                return s;
            };
            //Sử dụng delegate định nghĩa sắn tham chiếu tới câu lệnh lambda
            Func<int, int> p = (int x) =>
            {
                return x * x;
            };
            Console.WriteLine("Binh phuong cua 10 la:{0}", p(10));
            //in kết quả
            Console.WriteLine("Lap phung cua 3 la {0}", cube(3));
            Console.WriteLine("Tong tu 1 den 10 la {0}", sum(10));
            //gọi action chứa delegate
            int total = Calculate((no1, no2) => no1 + no2, 6, 7);
            Console.WriteLine("Tong 6+7={0}", total);

            // phần khởi tạo dữ liệu
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                EmpId = 1,
                EmpName = "Hoa",
                Salary =10000,
                City = "Hanoi"
            });
            employees.Add(new Employee
            {
                EmpId = 2,
                EmpName = "Cuong",
                Salary =20000,
                City = "Hanam"});
            employees.Add(new Employee
            {
                EmpId = 3,
                EmpName = "Hieu",
                Salary =30000,
                City = "Hanoi"
            });
            Console.WriteLine("Lọc theo City:");
            foreach (Employee emp in Filter(employees, emp => emp.City =="Hanoi"))
            {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("\nLọc theo Salary:");
            foreach (Employee emp in Filter(employees, emp => emp.Salary >=
            20000))
            {
                Console.WriteLine(emp.ToString());
            }

            //khai báo chung
            int[] Numbers = { 7, 9, 3, 5, 2, 1, 0, 6, 4, 3, 1 };
            string[] Words = {
                    "Chỉ","trích","phê", "phán", "người","khác",
                    "giống","như","con","chim","bồ","câu","đưa","thư",
                    "bao", "giờ","cũng", "quay","về","nơi","xuất", "phát"
                    };
                                List<Film> ListFilm = new List<Film>()
                    {
                    new Film{FilmId="F01",FilmName="Điệp viên 007",Price=120000},
                    new Film{FilmId="F02",FilmName="Tam quốc diễnnghĩa",Price=130000},
                    new Film{FilmId="F03",FilmName="Thiếu lâm truyềnkỳ",Price=16000},
                    new Film{FilmId="F04",FilmName="Người nhện 2",Price=100000},
                    new Film{FilmId="F05",FilmName="Ngân hàng tìnhyêu",Price=340000},
                    new Film{FilmId="F06",FilmName="Người đẹp và quáithú",Price=230000},
                    new Film{FilmId="F07",FilmName="Biệt động SàiGòn",Price=190000},
                    };
            //lọc các số chẵn
            IEnumerable<int> querynumber = Numbers.Where(n => n % 2 == 0);
            Show<int>(querynumber, "Loc cac so chan:");
            //lọc các từ có độ dài >4
            IEnumerable<string> queryword = Words.Where(w => w.Length > 4);
            Show<string>(queryword, "Loc cac tu co do dai >4:");
            //lọc các từ có tên bắt đầu bằng chữ t
            IEnumerable<string> queryT = Words.Where(w => w.StartsWith("t"));
            Show<string>(queryT, "Loc cac tu co ten bat dau bang chu t:");
            //Lọc các số duy nhất trong tập các số
            var uniqueNumber = Numbers.Distinct();
            Show<int>(uniqueNumber, "Loc cac so duy nhat trong tap cac so:");
            //Đếm xem có bao nhiêu từ không trùng nhau
            var countDistinct = Words.Distinct().Count();
            Console.WriteLine("Dem xem co bao nhieu tu khong trung nhau:" +
            countDistinct);
            //lấy 4 số đầu tiên trong dãy
            var fourNumber = Numbers.Take(4);
            Show<int>(fourNumber, "Lay 4 so dau tien trong day:");
            //lấy 2 từ đầu tiên trong câu
            var twoword = Words.Take(2);
            Show<string>(twoword, "Lay 2 tu dau tien trong cau:");
            //lấy những từ đầu tiên có chứa chữ t
            var searchword = Words.TakeWhile(w => w.Contains('t'));
            Show<string>(searchword, "Lay nhung tu dau tien co chua chu t:");
            //sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá <200000
            var queryfilm = ListFilm.OrderBy(f => f.Price)
            .Select(x => new { x.FilmId, x.FilmName, x.Price })
            .ToList().TakeWhile(t => t.Price < 200000);
            //bỏ qua 3 phần từ đầu tiên, lấy tất cả các phần tử còn lại
            var skipNumber = Numbers.Skip(3);
            Show<int>(skipNumber, "Bo qua 3 phan tu dau tien, lay tat ca phan tu con lai: ");
            //bỏ qua 4 phần từ đầu tiên lấy 3 phần tử kế tiếp
            var skipTakeNumber = Numbers.Skip(4).Take(3);
            Show<int>(skipTakeNumber, "Bo qua 4 phan tu dau tien, lay 3 phan tuke tiep: ");
            //bỏ qua 3 phim đầu tiên lấy 3 phim kết tiếp (có thể áp dụng đểphân trang)
            var skipTakeFilm = ListFilm.Skip(3).Take(3);
            Show<Film>(skipTakeFilm, "Bo qua 3 phim dau tien, lay 3 phim ketiep: ");
            //Sắp xếp giảm dần, sau đó lấy các phần tử <5
            var sortNumber = Numbers.OrderByDescending(x => x).SkipWhile(x => x> 5);
            Show<int>(sortNumber, "Sap xep giam dan, sau do lay cac phan tu< 5:");
        }

        //Tạo phương thức lọc dữ liệu
        public static IEnumerable<Employee> Filter(IEnumerable<Employee> employees, EmpDelegate check)
        {
            foreach (Employee emp in employees)
            {
                if (check(emp) == true)
                    yield return emp;
            }
        }
        static void Show<T>(IEnumerable<T> data, string message)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}