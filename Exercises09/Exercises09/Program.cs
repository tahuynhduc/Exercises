namespace Exercises09
{
    //khai báo Delegate tính toán 2 số nguyên
    delegate void Calculator(int num1, int num2);
    //khai báo delegate hiển thị 1 thông báo
    delegate void ShowMessage(string msg);
    class Program
    {
        //khai báo biến tĩnh
        static int num = 0;
        //Định nghĩa phương thức tĩnh cộng 2 số
        public static void AddNum(int p, int q)
        {
            num = p + q;
            Console.WriteLine("AddNum value: {0}", num);
        }
        /// <summary>
        /// Phương thức Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // bai 9.1
            //Tạo thể hiện của delegate sử dụng phương thức nặc danh
            Calculator pd = delegate (int x, int y)
            {
                Console.WriteLine("Phuong thuc nac danh: x={0},y={1}", x, y);
            };
            //gọi delegate sử dụng phương thức nặc danh
            pd(20, 10);
            //Tạo mới delegate sử dụng phương thức tường minh
            pd = new Calculator(AddNum);
            //gọi delegate sử dụng phương thức tường minh
            pd(10, 30);
            //Tạo thể hiện của delegate sử dụng phương thức nặc danh
            ShowMessage sm = delegate (string msg)
            {
                Console.WriteLine("Delegate 1:" + msg);
            };
            //Tham chiếu tới nhiều phương thức nặc danh
            sm += delegate (string msg)
            {
                Console.WriteLine("Delegate 2:" + msg);
            };
            //Gọi delegate sử dụng nhiều phương thức nặc danh
            sm("Hello every body!");
            Console.Read();

            // bai 9.2
            string s = "Ban that la tuyet voi.";
            //gọi phương thức mở rộng
            int count = s.WordCount();
            System.Console.WriteLine("Tong so tu cua s la: {0}", count);

            //bai 9.3
            //Tạo đối tượng nặc danh
            var employee = new
            {
                Name = "Lai Duc Chung",
                Age = 36,
                Address = "Ha Nam",
                Email = "chungld@bachkhoa-aptech.com",
                Married = 1
            };
            //In thông tin đối tượng nặc danh
            Console.WriteLine("Ho va ten: " + employee.Name);
            Console.WriteLine("Tuoi: " + employee.Age);
            Console.WriteLine("Dia chi: " + employee.Address);
            Console.WriteLine("Email: " + employee.Email);
            Console.WriteLine("Tinh trang: " + employee.Married);

            //bai 9.4
            //tạo đối tượng Employee
            Employee emp = new Employee();
            //gọi phương thức thành phần
            emp.CallDisplay();

            //bai 9.5
            //khai báo các biến có khả năng chứa dữ liệu null
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            // Hiển thị giá trị
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2,
            num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            //sử dụng toán tử kiểm tra xem biến có null không?
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            Console.ReadLine();
        }
    }
}