using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De01_22
{
    class Person
    {
        private string fname;
        private int age;

        public string Fname { get => fname; set => fname = value; }
        public int Age { get => age; set => age = value; }

        public virtual void Input()
        {
            Console.Write("Họ tên:" );
            Fname = Console.ReadLine();
            Console.Write("Tuổi:");
            Age = int.Parse(Console.ReadLine());
        }
    }
}
