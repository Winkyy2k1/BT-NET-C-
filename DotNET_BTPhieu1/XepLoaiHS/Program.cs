using System;

namespace XepLoaiHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            string hoten;
            float diem;
            Console.Write("Nhập họ tên:");
            hoten = Console.ReadLine();
            hoten = hoten.ToUpper();
            Console.Write("Nhập điểm: ");
            diem = float.Parse(Console.ReadLine());
            Console.WriteLine("Sinh viên: " + hoten);
            if (diem >= 8) Console.WriteLine("Xếp loại: Giỏi ");
            else if(diem < 8 && diem>= 6.5) Console.WriteLine("Xếp loại: Khá ");
            else if (diem < 6.5 && diem >= 5) Console.WriteLine("Xếp loại: TB ");
            else Console.WriteLine("Xếp loại: Yếu ");





        }
    }
}
