using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proj52
{
    class GiaiPhuongTrinhBac2
    {
        private int a;
        private int b;
        private int c;
        public GiaiPhuongTrinhBac2()
        {

        }
        public GiaiPhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public void Tinh()
        {
            Console.WriteLine(" PT: " + a + "x^2 + " + b + "x + " + c + " = 0.");
            float denta = b * b - 4 * a * c;
            if (denta < 0) Console.WriteLine(" Phương trình vô nghiệm. ");
            else
                if (denta == 0)
                    {
                        float x = -b / (2 * a);
                        Console.WriteLine(" Phương trình có nghiệm kép: " + x);
                    }    
            else
            {
                float x1 = (float) ((-b + Math.Sqrt(denta)) / (2 * a));
                float x2 = (float) ((-b - Math.Sqrt(denta)) / (2 * a));
                 Console.WriteLine(" Phương trình có 2 nghiệm phân biệt là: " + x1 + " và " + x2);
            }   
        }
        //class USE_PT
        //{
        //    public static void Main(string[] args)
        //    {
        //        GiaiPhuongTrinhBac2 pt = new GiaiPhuongTrinhBac2( 2,2,-10);

        //        pt.Tinh();
        //    }
        //}
    }
}
