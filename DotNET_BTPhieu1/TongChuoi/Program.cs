using System;

namespace TongChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            int n, A=0;
            float B =1;
            // Tinh tổng dãy số S= 1+2+3+...+n
            Console.Write("Nhập số nguyên dương n: ");
             n = int.Parse(Console.ReadLine());
            Console.WriteLine("Sô n đã nhập là: " + n );
            // Tính tổng S= 1+ 2+ 3+ ... n
            for( int i=1; i<= n; i++)
            {
                A += i;
            }    
            Console.WriteLine("Tong a là:" + A);

           
            for (int i = 2; i <= n; i++)
            {
                B += 1F/(i);
            }
            Console.WriteLine("Tong b là:" + B);
            Console.Read();
        }
    }
}
