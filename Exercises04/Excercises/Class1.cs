using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{
    class Window
    {
        //khai báo các trường
        protected int top;
        protected int left;
        //Phương thức khởi tạo
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        //phương thức virtual vẽ cửa sổ
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}", top, left);
        }
    }
    class Button : Window
    {
        //phương thức khởi tạo
        public Button(int top, int left)
        : base(top, left)//gọi constructor lớp cơ sở
        {
        }
        // Ghi đè phương thức
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
    //tạo lớp listbox kế thừa từ window
    class ListBox : Window
    {
        //Khai báo trường mới
        private string listBoxContents;
        //Phương thức khởi tạo
        public ListBox(int top, int left, string contents)
        : base(top, left) // gọi constructor lớp cơ sở
        {
            listBoxContents = contents;
        }
        // ghi đè phương thức DrawWindow
        public override void DrawWindow()
        {
            base.DrawWindow(); // gọi phương thức lớp cơ sở
            Console.WriteLine("Writing string to the listbox: {0}",
            listBoxContents);
        }
    }
}
