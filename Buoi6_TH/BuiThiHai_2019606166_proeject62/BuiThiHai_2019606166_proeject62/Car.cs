using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proeject62
{
    class Car:Vehicles
    {
        public string color; // màu sắc

        public Car()
        {
        }
        public Car(string id, string maker, string model, int year, double price,string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập màu sắc: ");
            color = Console.ReadLine();

        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Màu sắc: " + color);
        }
    }
}
