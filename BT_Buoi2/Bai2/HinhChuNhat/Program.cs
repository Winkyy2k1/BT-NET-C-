using System;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            double d, r, chuvi, S;
            do
            {
                Console.Write("Nhập chiều dài: ");
                d = double.Parse(Console.ReadLine());
            } while (d <= 0);

            do
            {
                Console.Write("Nhập chiều rộng: ");
                r = double.Parse(Console.ReadLine());
            } while (r <= 0);

            chuvi = (d + r) * 2;
            Console.WriteLine("Chu vi hcn la:" + chuvi);
            S = d * r;
            Console.WriteLine("Dien tich hcn la:" + S);
            Console.Read();
        }
    }
}
