using System;

namespace Mang
{
    class Program
    {  // Hien thi mảng 
        static void InMang(int n, int[] a)
        {
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        // Tim so lon nhat 
        static int TimMax(int n, int []a)
        { int amax = a[0];
            for( int i=1; i <n; i++)
            {
                if (a[i] > amax) amax = a[i];
            }
            return amax;
        }
        // Tim so nho nhat 
        static int TimMin(int n, int[] a)
        {
            int amin = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < amin) amin = a[i];
            }
            return amin;
        }
        // Tong cac phan tu trong mang
        static int Tong(int n, int[] a)
        {
            int Tong = 0;
            for (int i = 0; i < n; i++)
            {
               Tong+=a[i];
            }
            return Tong;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            int n;
           
            Console.Write("Nhập số phần tử của mảng: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            int[] a = new int[n];
            Console.WriteLine("Nhập các phần tử của mảng: ");
            for( int i=0; i<n; i++)
            {
                Console.Write("a[ " + i + " ]= ");
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang vua nhap la: ");
            InMang(n, a);
            Console.WriteLine("So lon nhất trong mảng là:" + TimMax(n,a));
            Console.WriteLine("So nho nhất trong mảng là:" + TimMin(n, a));
            Console.WriteLine("Tong mang la:" + Tong(n,a));
        }
    }
}
