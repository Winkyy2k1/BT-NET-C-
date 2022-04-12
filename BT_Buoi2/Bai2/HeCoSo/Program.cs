using System;

namespace HeCoSo
{   
        //1. chuyển đổi số nguyên n từ hệ cơ số 10 sang hệ cơ số b bất kỳ.
            
        
        //2. chuyển đổi một số n từ hệ cơ số b bất kỳ sang hệ cơ số 10.
        //trong đó n, b nhập vào từ bàn phím.

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen n: ");
                 n = Convert.ToInt32(Console.ReadLine());
            } while (n == 0);
            Console.WriteLine(" So nguyen vua nhap là: " + n);
            Console.WriteLine("Hello World!");
        }
    }
}
