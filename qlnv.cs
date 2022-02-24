using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNVcsharp
{
    public class qlnv
    {
        private nv[] data;
        public int n { get; set; }
        public qlnv()
        {
            data = null!;
            n = 0;
        }
        public void add(){
           nv[] newNV = new nv[n];
           for(int i=0;i<n;i++){
               newNV[i] = data[i];
           }
           n--;
           data = new nv[n];
           Console.WriteLine("Nhap thong tin nhan vien");
            data[n-1].nhapTTNV();
            for(int i=0;i<n;i++){
               data[i] = newNV[i];
           }
        }
        public void output()
        {
            for(int i=0;i<n;i++){
                data[i].xuatTTNV();
            }
        }
        public void insert(int index)
        {
            int newN  = n +1;
           nv[] newNV = new nv[newN];
           for(int i=n;i>=index;i--){
               newNV[i] = data[i-1];
           }
           Console.WriteLine("Nhap thong tin nhan vien");
            newNV[index-1].nhapTTNV();
            data = newNV;
            n = newN;
        }
        public int indexOf(nv o)
        {
            int index = -1;
            if (n == 0)
                return index;
            for (int i = 0; i < n; i++)
            {
                if (o.Equals(data[i]))
                    return i;
            }
            return -1;
        }
        public void remove(nv o)
        {
            if (n == 0)
            {
                Console.WriteLine("Danh sach khong co nhan vien");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (data[i].Equals(o))
                {
                    nv[] t = new nv[n];
                    t = data;
                    data = new nv[n - 1];
                    int k = 0;
                    for (int j = 0; j < n; ++j)
                    {
                        if (j != i)
                        {
                            data[k] = t[j];
                            ++k;
                        }
                    }
                    --n;
                }
            }
        }
        public void removeAtIndex(int index)
        {
            if (n == 0)
            {
                Console.WriteLine("Danh sach khong co nhan vien");
                return;
            }

            nv[] t = new nv[n];
            t = data;
            data = new nv[n - 1];
            int j = 0;

            for (int i = 0; i < n; ++i)
            {
                if (i != index)
                {
                    data[j] = t[i];
                    ++j;
                }
            }
            --n;
        }
    }
}