using System;
using System.Collections;

namespace DanhSach
{   
    class Program
    {   
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            ArrayList ThanhPho = new ArrayList();
            ThanhPho.Add("Hà Nội");
            ThanhPho.Add("TP Hồ Chí Minh");
            ThanhPho.Add("Đà Nẵng");
            ThanhPho.Add("Hải Phòng");
            ThanhPho.Add("Hưng Yên");
            Console.WriteLine("\nDanh sach thanh pho vua them la: ");
                foreach( var item in ThanhPho)
                {
                    Console.Write(item + " - ");
                }
            // sắp xep thu tu tang dan A-Z
            ThanhPho.Sort();
            Console.WriteLine("\nDanh sach thanh pho sau sap xep la: ");
                foreach (var item in ThanhPho)
                {
                    Console.Write(item + " - ");
                }
            // Xoa Hà Nội, them 5 thanh phố khác
            ThanhPho.Remove("Hà Nội");
            ThanhPho.Add(" Nam Định");
            ThanhPho.Add("Hà Nam");
            ThanhPho.Add("Ninh Bình");
            ThanhPho.Add("Quảng Ninh");
            ThanhPho.Add("Thái Nguyên");
            Console.WriteLine("\nDanh sach thanh pho sau xoa và thêm la: ");
                foreach (var item in ThanhPho)
                {
                    Console.Write(item + " - ");
                }
        }
    }
}
