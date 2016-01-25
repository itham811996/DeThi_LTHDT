using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_BaiTap
{
    public abstract class Nguoi
    {
        string hoTen;
        int namSinh;
        string bangCap;

        public Nguoi()
        {
            this.hoTen = "";
            this.namSinh = 1995;
            this.bangCap = "";
        }

        public Nguoi(string hoTen, int namSinh, string bangCap)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.bangCap = bangCap;
        }

        public string HoTen
        {
            get
            {
                return this.hoTen;
            }
            set
            {
                this.hoTen = value;
            }
        }

        public int NamSinh
        {
            get
            {
                return this.namSinh;
            }
            set
            {
                this.namSinh = value;
            }
        }

        public string BangCap
        {
            get
            {
                return this.bangCap;
            }
            set
            {
                this.bangCap = value;
            }
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap Nam Sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap Bang Cap: ");
            BangCap = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.Write("{0,20} {1,4} {2,20}",HoTen,NamSinh,BangCap);
        }
    }
}
