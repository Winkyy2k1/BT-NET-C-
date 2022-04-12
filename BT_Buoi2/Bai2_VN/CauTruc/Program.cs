using System;
using System.Collections.Generic;

namespace CauTruc
{
    class Program
    {
        struct hocSinh
        {
            public string ten;
            public byte tuoi;
            public bool gioiTinh;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            hocSinh[] hs = new hocSinh[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nhập học sinh thứ {0}", i + 1);
                Console.Write("Nhập tên: ");
                hs[i].ten = Console.ReadLine();
                Console.Write("Nhập tuổi: ");
                hs[i].tuoi = Convert.ToByte(Console.ReadLine());
                sum += hs[i].tuoi;
                Console.Write("Nhập giới tính (nam = true, nữ = false): ");
                hs[i].gioiTinh = Convert.ToBoolean(Console.ReadLine());

            }
            Console.WriteLine("Tổng số tuổi = " + sum);
            Console.ReadLine();
        }
    }
}
