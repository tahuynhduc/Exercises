namespace exercises02
{
    class program
    {
        static void Main(string[] args)
        {
            // bai 2.1
            //khai báo biến
            string name;
            int number;
            double money = 0;
            //Nhập thông tin
            Console.Write("Nhap ten thue bao:");
            name = Console.ReadLine();
            Console.Write("Nhap so dien su dung:");
            number = Convert.ToInt32(Console.ReadLine());
            //tính toán số tiền
            if (number <= 30)
                money = 30;
            else if (number > 30 && number <= 50)
                money = 30 + (number - 30) * 1.2;
            else if (number > 50)
                money = 30 + 20 * 1.2 + (number - 50) * 1.5;
            //in thong tin
            Console.WriteLine("\n Thong tin tien dien");
            Console.WriteLine("Ho va ten:{0}", name);
            Console.WriteLine("So dien su dung:{0}", number);
            Console.WriteLine("So tien:{0:C}", money);

            // bai 2.2
            char ch;
            Console.WriteLine("Nhap vao ky tu:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    Console.WriteLine("{0} la nguyen am.", ch);
                    break;
                default:
                    Console.WriteLine("{0} la phu am.", ch);
                    break;
            }
            

            //bai 2.3
            //Khai báo các biến
            double a, b, c, delta, x1, x2;
            //Nhập a,b,c
            Console.Write("a=");
            //a phải !=0
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a == 0);
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());
            //tính delta
            delta = b * b - 4 * a * c;
            //biện luận
            if (delta < 0)
                Console.Write("Phuong trinh vo nghiem");
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep");
                Console.WriteLine("x1=x2={0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1={0}", x1);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x2={0}", x2);
            }

            // bai 2.4
            //khai báo biến đánh dấu
            bool check_i;
            Console.Write("Danh sach cac so nguyen to tu 2-100: ");
            //duyệt từ 2-100
            for (int i = 2; i <= 100; i++)
            {
                check_i = true; //giả sử i là số nguyên tố
                for (int j = 2; j <= i / 2; j++) //duyệt từ 2-j/2
                {
                    if (i % j == 0)//nếu i chia hết cho j thì
                    {
                        check_i = false;//kết luận không là số nguyên tố
                        break;//thoát khỏi vòng lặp hiện tại
                    }
                }
                if (check_i) //nếu giả sử vẫn đúng -> i là số nguyên tố
                    Console.Write(" {0} ", i);
            }

            //bai 2.5

            //khai báo biến tổng
            int sum = 0;
            //duyệt từ 1-100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 != 0)
                {
                    sum += i;
                }
            }
            //in kết quả
            Console.WriteLine("Tong cac so chan khong chia het cho 3 tu 1-100 la{ 0}", sum);

            // bai 2.6
            string[] names = { "Thang", "Long", "Hoa", "Dao" };
            Console.Write("Danh sanh sinh vien:\n");
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}