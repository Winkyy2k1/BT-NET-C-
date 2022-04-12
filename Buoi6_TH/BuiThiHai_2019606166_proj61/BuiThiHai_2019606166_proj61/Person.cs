using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proj61
{
    class Person
    {
        public int id { get; set; }
        public string name{ get; set; }
        public string address { get; set; }
         public Person()
        {

        }

        public Person(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhập id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập name: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập address: ");
            address = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.WriteLine(" === OUT PUT =====");
            Console.WriteLine("{0, 5}{1, 10 }{2, 10}", id, name, address);
        }
      
    }
}
