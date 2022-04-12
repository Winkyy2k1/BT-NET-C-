using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proj52
{
    class TimUCLN
    {
        private int sothu1;
        private int sothu2;
        public TimUCLN()
        {

        }
        public TimUCLN(int sothu1, int sothu2)
        {
            this.sothu1 = sothu1;
            this.sothu2 = sothu2;
        }

        public int Sothu1 { get => sothu1; set => sothu1 = value; }
        public int Sothu2 { get => sothu2; set => sothu2 = value; }

        public static int Tim(int a, int b)
        {
           while ( a!= b)
            {
                if (a > b)
                    a = a - b;
                else b = b - a;

            }
            return a;
        }

       
       class UseUCLN
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Bài toán tìm UCLN của mảng đối tượng");
                Console.Write("Nhập số phần tử của mang đối tượng: ");
                int size = Convert.ToInt32(Console.ReadLine());
                TimUCLN[] arr = new TimUCLN[size];

                Console.WriteLine("Nhập các cặp số của từng đối tượng: ");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Cặp đối tượng ", i);
                    arr[i] = new TimUCLN();
                    Console.Write("Nhập số thứ nhất ");
                    arr[i].sothu1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhập số thứ nhất ");
                    arr[i].sothu2 = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Kết quả sau chạy chương trình là");
                for (int i = 0; i < size; i++)
                {
                    int kq = Tim(arr[i].sothu1, arr[i].sothu2);
                    Console.WriteLine("UCLN cua " + arr[i].sothu1 + " và " + arr[i].sothu2 + " là: " + kq);
                }

            }
        }
    }
}
