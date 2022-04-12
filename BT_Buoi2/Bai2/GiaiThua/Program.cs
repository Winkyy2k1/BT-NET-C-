using System;

namespace GiaiThua
{
    class Program
    {   static int GiaiThua(int n)
        {
            if (n == 0 || n == 1) return 1;
            return (n * GiaiThua(n - 1));
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int n;
            do
            {
                Console.Write("Nhập số nguyên dương n:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            Console.Write(" \n Giai thua cua " + n + " la: " + GiaiThua(n));
            
            
        }
    }
}
