using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_pj4
{
    class Circle
    {
        const double pi = 3.14159;

        public double radius { get; set; }


        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Chuvi()
        {
            return 2 * radius * pi;
        }

        public double DienTich()
        {
            return radius * radius * pi;
        }


        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.radius = 3;
            Console.WriteLine("Chu vi hinh tron la: " + c.Chuvi());
            Console.WriteLine("Dien tich hinh tron la: " + c.DienTich());

        }
    }
}
