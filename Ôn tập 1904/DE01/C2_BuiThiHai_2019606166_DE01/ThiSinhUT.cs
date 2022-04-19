using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_BuiThiHai_2019606166_DE01
{
    class ThiSinhUT : ThiSinh, IComparable
    {
        public int khuvuc { get; set; }
        public float diemuutien { get; set; }

        public ThiSinhUT()
        {

        }

        public ThiSinhUT(int khuvuc, float diemuutien)
        {
            this.khuvuc = khuvuc;
           
        }

        public void NhapThongTin()
        {
            Console.WriteLine(" NHẬP THÔNG TIN CỦA THÍ SINH ");
            Console.Write(" Nhập số báo danh: ");
            sbd = Console.ReadLine();
            Console.Write(" Nhập họ tên: ");
            hoten = Console.ReadLine();
            Console.Write("Nhập điểm toán: ");
            diemtoan = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý: ");
            diemly = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hoá: ");
            diemhoa = float.Parse(Console.ReadLine());
            Console.Write("Nhập khu vực: ( từ 1-3) ");
            khuvuc = int.Parse(Console.ReadLine());
            if (khuvuc == 1) diemuutien = 0;
            else if (khuvuc == 2) diemuutien = (float) 0.5;
            else if (khuvuc == 3) diemuutien = 1;
            Console.WriteLine("Điểm ưu tiên là: " +diemuutien);
        }

        public void HienThi()
        {
            Console.WriteLine("{0, 5}{1, 10}{2,10}{3,5}{4,5}{5,5}{6,5}{7,5}", sbd,hoten, diemtoan, diemly, diemhoa, khuvuc, diemuutien, Tongdiem());
        }

        public override float Tongdiem()
        {
             return diemtoan + diemly + diemhoa+ diemuutien; 
        }
        public int CompareTo(object obj)
        {
            ThiSinhUT t = (ThiSinhUT)obj;
            return (this.Tongdiem().CompareTo(t.Tongdiem() ));
        }

        public override bool Equals(object obj)
        {
            return obj is ThiSinhUT uT &&
                   sbd == uT.sbd;
        }
    }
}
