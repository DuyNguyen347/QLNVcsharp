using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVcsharp
{
    public class Program
    {
        static public void Main(string[] args)
        {
            qlnv ql = new qlnv();
            //int a;
            // Console.WriteLine("1.Them nhan vien ");
            // Console.WriteLine("2.Xuat danh sach nhan vien");
            // Console.WriteLine("3.Them nhan vien vao vi tri i");
            // Console.WriteLine("4.Tim kiem nhan vien");
            // Console.WriteLine("5 Xoa nhan vien");
            //a = Convert.ToInt32(Console.ReadLine());
            ql.add();
            ql.output();
            
        }
    }
}
