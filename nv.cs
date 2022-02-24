using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVcsharp
{
    public class nv
    {
        public string ? mssv{get;set;}
        public string ? hoten{get;set;}
        public string ? quequan{get;set;}
        public int namsinh{get;set;}
        public int gioitinh{get;set;}
        public nv()
        {
            mssv = null;
            hoten = null;
            quequan = null;
            namsinh = 0;
            gioitinh = 0;
        }
        public nv(string mssv,string hoten,string quequan,int namsinh,int gioitinh)
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.quequan = quequan;
            this.namsinh= namsinh;
            this.gioitinh = gioitinh;
        }

        public void nhapTTNV(){
            Console.Write("Nhap ma so nhan vien");
            mssv = Console.ReadLine();
            Console.Write("Nhap ten nhan vien");
            hoten = Console.ReadLine();
            Console.Write("Nhap que quan nhan vien");
            quequan = Console.ReadLine();
            Console.Write("Nhap nam sinh nhan vien");
            namsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap gioi tinh nhan vien(0.Nam ! 1.Nu");
            gioitinh = Convert.ToInt32(Console.ReadLine());
        }
        public void xuatTTNV(){
            Console.WriteLine("MSNV : {0}",mssv);
            Console.WriteLine("Ten NV : {0}",hoten);
            Console.WriteLine("Nam sinh : {0}",namsinh);
            Console.WriteLine("Que Quan : {0}",quequan);
            if(gioitinh == 0 )
            Console.WriteLine("Gioi tinh : Nam");
            else if (gioitinh == 1)
            Console.WriteLine("Gioi tinh : Nu");
        }
    }
}