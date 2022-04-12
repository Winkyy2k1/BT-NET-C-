using System;

namespace CanBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số cần tính căn a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhập độ chính xác epsilon e: ");
            double e = Convert.ToDouble(Console.ReadLine());

            double kq = 1.0F;
            while (Math.Abs(kq * kq - a) / a >= e)
                kq = (a / kq + kq) / 2;
            Console.WriteLine("Căn bậc 2 của {0} = {1}", a,  kq);
            Console.ReadLine();

        }
    }
}