using System;

namespace DanhSach
{
    class Program
    {   // hàm in ds chẵn
        static void MangChan(int n, int[] a)
        {
            foreach (int item in a)
            {   if( item %2 == 0 )
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        // hàm in ds lẻ
        static void MangLe(int n, int[] a)
        {
            foreach (int item in a)
            {
                if (item % 2 == 1)
                    Console.Write(item + " ");
            }
            Console.WriteLine( );
        }
        // hàm ktra số nguyên tố
        public static int NguyenTo( int n)
        {
            if (n < 2) return 0;
            else
            {
                for (int i = 2; i <= n / 2; i++)
                    if (n % i == 0)
                        return 0;
                return 1;
            }    
        }
        // hàm in số nguyên tố
        public static void InNT(int n, int[] a)
        {
            for( int i=0; i<n; i++)
                {
                    if( NguyenTo( a[i] ) ==1 )
                Console.Write(a[i] + " ");
                }    
        }

        // hàm in mảng
        static void InMang( int n, int [] a)
        {
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            int n;
            do
            {
                Console.Write("Nhập số nguyên n :");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            int[] a = new int[n];
            Console.WriteLine(" Nhập mảng số nguyên: ");
            for( int i=0; i<n; i++)
            {
                Console.Write(" a [" + i + "] =" );
                a[i]= Convert.ToInt32(Console.ReadLine()) ;
            }
            Console.Write("Mảng là:");
                InMang(n,a);
            

            Console.Write("Mảng chẵn là:");
            MangChan(n, a);
            
            Console.Write("Mảng lẻ là:");
            MangLe(n, a);

            Console.Write("Mảng số ngyên tố là:");
            InNT(n, a);



        }
    }
}
