using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT_BaiTap
{
    public class NhaQuanLy:Nguoi
    {
        string chucVu;
        float soNgayCong;
        float bacLuong;

        public NhaQuanLy()
            : base()
        {
            this.chucVu = "";
            this.soNgayCong = 0.0F;
            this.bacLuong = 0.0F;
        }

        public NhaQuanLy(string hoTen, int namSinh, string bangCap, string chucVu, float soNgayCong, float bacLuong)
            : base(hoTen,namSinh,bangCap)
        {
            this.chucVu = chucVu;
            this.soNgayCong = soNgayCong;
            this.bacLuong = bacLuong;
        }

        public string ChucVu
        {
            get
            {
                return this.chucVu;
            }
            set
            {
                this.chucVu = value;
            }
        }

        public float SoNgayCong
        {
            get
            {
                return this.soNgayCong;
            }
            set
            {
                this.soNgayCong = value;
            }
        }

        public float BacLuong
        {
            get
            {
                return this.bacLuong;
            }
            set
            {
                this.bacLuong = value;
            }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Chuc Vu: ");
            ChucVu = Console.ReadLine();
            Console.Write("Nhap So Ngay Cong: ");
            SoNgayCong = float.Parse(Console.ReadLine());
            Console.Write("Nhap Bac Luong: ");
            BacLuong = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("{0,20} {1,2:2F} {2,3:2F}", ChucVu, SoNgayCong, BacLuong);
        }
    }
}
