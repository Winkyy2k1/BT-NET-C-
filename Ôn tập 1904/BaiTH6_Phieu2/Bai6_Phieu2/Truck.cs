using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Phieu2
{
    class Truck:Vehicles
    {
        public int truckload { get; set; }
        public Truck(string id, string maker, string model, int year, double price,int truckload) : base(id, maker, model, year, price)
        {   
            this.truckload = truckload;
        }
        public virtual void Input()
        {
            base.Input();
            Console.WriteLine("Nhập tải trọng: ");
            truckload = int.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            base.Output();
            Console.WriteLine("Tải trọng: " + truckload);
        }
    }
}
