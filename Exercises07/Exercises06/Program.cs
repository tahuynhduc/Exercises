using System.Collections;

namespace Exercises06
{
    class program
    {
        static void Main(string[] args)
        {
            // bai 7.1
            //tạo ArrayList
            ArrayList inv = new ArrayList();
            //thêm phần tử vào dánh sách
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));
            //in ra danh sách phần tử
            Console.WriteLine("Product list:");
            foreach (Product i in inv)
            {
                Console.WriteLine(" " + i);
            }

            // bai 7.2

            //Tạo sortedlist generic
            SortedList<string, string> listEm = new SortedList<string, string>();
            //đưa dữ liệu vào
            listEm.Add("E01", "Tran Thi Thuy");
            listEm.Add("E02", "Le Hai Ha");
            listEm.Add("E03", "Nguyen Van Hung");
            listEm.Add("E04", "Hoang Thi Thom");
            listEm.Add("E05", "Trinh Van Chien");
            //in danh sách
            Console.WriteLine("Danh sach nhan vien");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
            //tìm kiếm tất cả các nhân viên có tên bắt đầu bằng chữ Th
            Console.WriteLine("Danh sach nhan vien bat dau bang chu Th");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("Th"))
                    Console.WriteLine(key + ":" + listEm[key]);
            }
            //xóa nhân viên có mã E04
            listEm.Remove("E04");
            //Kiểm tra nếu chưa có nhân viên E06 thì thêm vào
            if (!listEm.ContainsKey("E06"))
                listEm.Add("E06", "Nguyen Hoai Linh");
            //in danh sách sau khi xoa, them
            Console.WriteLine("Danh sach nhan vien sau khi xoa, them");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }

            // bai 7.3
            //khai báo và khởi tạo danh sách sinh viên sử dụng List generic
            List<Student> list = new List<Student>()
            {
            new Student{Id="S10",FirstName="Thu",LastName="Phuong",Avg=9.5},
            new Student{Id="S12",FirstName="Tran Thi",LastName="Thuy",Avg=9.0},
            new Student{Id="S13",FirstName="Le Hoang",LastName="Nhat",Avg=8.0},
            new Student{Id="S14",FirstName="NguyenVan",LastName="Phong",Avg=6.5},
            new Student{Id="S15",FirstName="Hoang Thi",LastName="Hue",Avg=9.7},
            new Student{Id="S16",FirstName="NguyenTien",LastName="Tung",Avg=5.0},
            new Student{Id="S17",FirstName="Thien",LastName="Nhan",Avg=4.8}
            };
            //in danh sách sinh viên
            Console.WriteLine("Danh sach sinh vien:");
            foreach (var st in list)
            {
                Console.Write(st);
            }
            //tìm sinh viên có điểm trung bình cao nhất
            double max = list[0].Avg;
            Student stmax = list[0];
            foreach (var st in list)
            {
                if (st.Avg > max)
                {
                    max = st.Avg;
                    stmax = st;
                }
            }
            //in kết quả
            Console.WriteLine("\nSinh vien co diem cao nhat la:");
            Console.Write(stmax);
            //sắp xếp danh sách sinh viên tăng dần theo điểm trung bình
            list.Sort();
            Console.WriteLine("\nDanh sach sinh vien diem trung binh tang dan:");
            foreach (var st in list)
            {
                Console.Write(st);
            }
        }
    }
}