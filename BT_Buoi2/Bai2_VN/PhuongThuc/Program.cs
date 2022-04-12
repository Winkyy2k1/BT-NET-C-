using System;

namespace PhuongThuc
{
    class Program
    {   public static int Ktra(int a)
        {
            if (a < 2) return 0;
            else
            {
                for (int i = 2; i <= a / 2; i++)
                    if (a % i == 0) return 0;

                return 1;
            }   
        }
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap số nguyên n: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 0);
            int[] Mang = new int[n];
            //Nhap mang so nguyen
            for(int i=0; i<n; i++)
            {
                Console.Write("Nhap so phan tu thu "+ (i +1 ) + " : ");
                Mang[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\n Mảng vừa nhập là: ");
                foreach( int item in Mang)
                {
                    Console.Write(item + " ");
                }
            Console.WriteLine("\n Các số nguyên tố la:");
            for(int i=0; i<n; i++)
            {
                if( Ktra(Mang[i])==1)
                    Console.Write(Mang[i] + " ");
            }    
        }
    }
}
