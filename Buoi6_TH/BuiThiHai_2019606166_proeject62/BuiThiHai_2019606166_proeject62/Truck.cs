using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proeject62
{
    class Truck:Vehicles
    {
        public int truckload { get; set; }
        public Truck():base()
        {
        }
        public Truck(string id, string maker, string model, int year, double price,int truckload) : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhập tải trọng kiểu int: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Tải trọng: " + truckload );
        }
    }
}
