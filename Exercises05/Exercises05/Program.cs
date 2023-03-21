using Exercises05.Store;
using static System.Net.Mime.MediaTypeNames;

namespace Exercises05
{
    class program
    {
        static void Main(string[] args)
        {
            // bai 5.1
            //Tạo đối tượng
            Product p = new Product();
            //Thiết lập giá trị cho các thuộc tính
            p.Id = 101;
            p.Name = "IPhone 6 Plus";
            p.Price = 21500000;
            p.Quantity = 4;
            p.Discount = 200000;
            //In ra thông tin
            Console.WriteLine("Id:" + p.Id);
            Console.WriteLine("Name:" + p.Name);
            Console.WriteLine("Price:" + p.Price);
            Console.WriteLine("Quantity:" + p.Quantity);
            Console.WriteLine("Total:" + p.Total);
            //Khởi tạo đối tượng
            Product p1 = new Product()
            {
                Id = 102,
                Name = "Galaxy S6 edge",
                Price =
            1800000,
                Discount = 100000,
                Quantity = 3
            };
            //In ra thông tin
            Console.WriteLine("Id:" + p1.Id);
            Console.WriteLine("Name:" + p1.Name);
            Console.WriteLine("Price:" + p1.Price);
            Console.WriteLine("Quantity:" + p1.Quantity);
            Console.WriteLine("Total:" + p1.Total);

            // bai 5.2
            ///khởi tạo đối tượng sinh viên với 3 sinh viên và mỗi sinh viên gồm 2điểm
            Student st = new Student(3, 2);
            //sử dụng chỉ mục để truy cập vào thành phần mảng của lớp
            st[0] = "Nam";
            st[0, 0] = 9;
            st[0, 1] = 6.5;
            st[1] = "Long";
            st[1, 0] = 5;
            st[1, 1] = 7.5;
            st[2] = "Hanh";
            st[2, 0] = 10;
            st[2, 1] = 9.5;
            //in ra thông tin
            Console.WriteLine("Thong tin sinh vien");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ho va ten:" + st[i]);
                Console.Write("Diem: ");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(st[i, j] + ",");
                }
                Console.WriteLine();
            }

            // bai 5.3
            //tạo đối tượng book
            Book b = new Book("Programming with Csharp", 4);
            //nhập thông tin các chương
            b[0] = new Chapter("Chapter 1", "Intoduction to Csharp");
            b[1] = new Chapter("Chapter 2", "DataType and Variables in Csharp");
            b[2] = new Chapter("Chapter 3", "Input and Output in Console Application");
            b[3] = new Chapter("Chapter 4", "Statements Conditions and Loops");
            //in thông tin sách
            Console.WriteLine("List of book:");
            Console.WriteLine(b.Name);
            // danh sách chương
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(b[i]);
            }
            //thông tin chương 3
            Console.WriteLine("Detail of Chapter 3");
            Console.WriteLine(b["Chapter 3"]);
            Console.Read();

            // bai 5.4
            //Tạo mới nhà phân phối cung cấp đầy đủ namespace
            Supply.Manufacturer dealer = new Supply.Manufacturer();
            //gán giá trị
            dealer.Name = "Coca cola";
            dealer.Email = "cocacolap@gmail.com";
            dealer.Phone = "(111)791-8074";
            //in thông tin
            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " + dealer.Name);
            Console.WriteLine("\t Email: " + dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);
            //tạo mới sản phẩm nằm trong namespace Store
            StoreItem si = new StoreItem();
            //gán giá trị
            si.ItemNo = 613508;
            si.ItemName = "Fanta";
            si.Price = 80.00M;
            //in thông tin
            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #: ");
            Console.WriteLine(si.ItemNo);
            Console.Write("\t Item Name: ");
            Console.WriteLine(si.ItemName);
            Console.Write("\t Unit Price: ");
            Console.WriteLine(si.Price);

            Console.Read();

            // bai 5,5
            //tạo mới đối tượng House trong namespace Business
            //bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.House h = new Business.House();
            //gán thông tin
            h.HouseNo = "D294FF";
            h.Price = 425880;
            //in thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No:" + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);
            //tạo mới đối tượng car trong namespace Business.Dealership
            //bạn có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A0999";
            c.Price = 38425.50M;
            //in thông tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No:" + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);
        }
    }
}