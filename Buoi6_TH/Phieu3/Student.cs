using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phieu3
{
    class Student
    {
        //static int count = 0;
        public int StudentId { get; set; }
        String Name { get; set; }
        String Mark { get; set; }
        public override string ToString()
        {
            return String.Format("\t\t{0,-20} {1,-15}{2,-15}\n", StudentId, Name, Mark);
        }
        public  void InputStudent()
        {
            Console.Write("nhap StudentId :");
            StudentId = int.Parse(Console.ReadLine());
            Console.Write("nhap name :");
            Name = Console.ReadLine();
            Console.Write("nhap mark :");
            Mark  = Console.ReadLine();
        }
        public static void InTieuDe()
        {
            Console.Write(String.Format("\t\t{0,-20} {1,-15}{2,-15}\n", "StudentId", "Name", "Mark"));
        }

    }
}
