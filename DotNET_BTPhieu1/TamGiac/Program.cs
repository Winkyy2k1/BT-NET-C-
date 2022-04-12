using System;

namespace TamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;  
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            
            double a, b, c, P, DT;
            Console.Write("Nhập a= ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhập b= ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Nhập c= ");
            c = double.Parse(Console.ReadLine());
            P = a + b + c;
            Console.WriteLine(" Chu vi la: " + P);
            P=P/2.0;
            DT = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine(" Dien tich la: " + DT);
            Console.Read();
        }
    }
}
