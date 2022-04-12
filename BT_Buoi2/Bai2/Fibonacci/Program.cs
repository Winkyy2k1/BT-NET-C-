using System;

namespace Fibonacci
{
    class Program
    {   public static int Fibo( int n)
        {
            if (n == 1) return 1;
            if (n == 0) return 0;
             return Fibo(n - 1) + Fibo(n - 2);

        }
        static void Main(string[] args)
        {   Console.OutputEncoding = System.Text.Encoding.UTF8;  
            Console.InputEncoding = System.Text.Encoding.UTF8;
            int n;
            do
            {
                Console.Write("Nhập số nguyên dương n:");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);

            Console.Write(" \n Dãy n số Fibonaci là: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(Fibo(i) + " "  );
            }    
            
        }
    }
}
