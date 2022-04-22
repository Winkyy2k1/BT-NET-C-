using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_22
{
    class Employee:Person,IComparable
    {
        private int id;
        private int soNgayCong;
        private float luong;
        private float thuong;
        public Employee()
        {

        }
        public Employee(int id)
        {
            this.id = id;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("id:");
            id = int.Parse(Console.ReadLine());
            Console.Write("Số ngày công:");
            soNgayCong = int.Parse(Console.ReadLine());
            Console.Write("lương:");
            luong = float.Parse(Console.ReadLine());
            if (soNgayCong >= 27)
            {
                thuong = 500;
            }
            else if (soNgayCong >= 25)
            {
                thuong = 300;
            }
            else thuong = 0;
        }
        public override string ToString()
        {
            return String.Format("{0,-8}{1,-16}{2,-24}{3,10}{4,15}{5,20}", id, Fname, Age, soNgayCong, luong, thuong);
        }
        public override bool Equals(object obj)
        {
            Employee e = (Employee)obj;
            return this.id.Equals(e.id);
        }
        public int CompareTo(object obj)
        {
            Employee e = (Employee)obj;
            return this.luong.CompareTo(e.luong);
        }
      
    }
}
