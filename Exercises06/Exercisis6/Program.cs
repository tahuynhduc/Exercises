using Exercisis6;

namespace exercisis06
{
    delegate void FunctionToCall(ref int X);

    class program
    {
        public static void Add2(ref int x)
        {
            x += 2;
        }
        //định nghĩa phương thức Add3 với tham số sử dụng từ khóa ref
        public static void Add3(ref int x)
        {
            x += 3;
        }
        static void Main(string[] args)
        {
            // bai 6.1
            //khai báo mảng
            byte[] a = new byte[5];
            //nhập mảng
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.Write("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap ki tu cho mang so");
            }
            catch (OverflowException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }
            //in mảng
            Console.WriteLine("Noi dung mang");
            for (int i = 0; i < 5; i++)
                Console.Write(" {0}", a[i]);

            //bai 6,2
            int intCnt;
            int intNum = 0;
            Console.Write("Nhap 1 so :");
            //nhập và tung ngoại lệ
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch (InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    //in ra dãy số *100
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();

            //// bai 6.3
            ////khởi tọa đối tượng MyClass
            //MyClass t = new MyClass();
            ////tạo delegate tham chiếu tới phương thức không tĩnh
            //FunctionToCall functionDelegate = t.nonStaticMethod;
            ////cộng tiếp với phương thức tĩnh
            //functionDelegate += MyClass.staticMethod;
            ////cộng tiếp với phương thức không tĩnh
            //functionDelegate += t.nonStaticMethod;
            ////cộng tiếp với phương thức tĩnh
            //functionDelegate += MyClass.staticMethod;
            ////thực thi delegate -> tất cả các phương thức tham chiếu tới đ được gọi
            //functionDelegate();

            // bai 6.4
            //gán delegate
            FunctionToCall functionDelegate = Add2;
            //cộng tiếp delegate
            functionDelegate += Add3;
            //cộng tiếp delegate
            functionDelegate += Add2;
            //khai báo biến x
            int x = 5;
            //gọi delegate và truyền tham số sử dụng ref
            functionDelegate(ref x);
            //in kết quả
            Console.WriteLine("Value: {0}", x);

            // bai 6.5
            //Khởi tạo đối tượng lớp TestOdd
            TestOdd objOdd = new TestOdd();
            //Đăng ký sự kiện
            objOdd.OnOddNumber += new OddNumberFinder(objOdd.ShowOdd);
            //gọi phương thức đếm số lẻ
            objOdd.CountOdd();
        }
    }
}