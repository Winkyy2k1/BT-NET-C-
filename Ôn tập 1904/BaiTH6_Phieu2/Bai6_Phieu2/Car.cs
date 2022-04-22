using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Phieu2
{
    class Car:Vehicles
    {
        public string color { get; set; }

        public Car():base()
        {

        }
        public Car(string id, string maker, string model, int year, double price,string color):base(id,maker,model,year,price)
        {
            this.color = color;
        }
        public virtual void Input()
        {
            base.Input();
            Console.WriteLine("Nhập màu: ");
            color = Console.ReadLine();
        }
        public virtual void Output()
        {
            base.Output();
            Console.WriteLine("Màu sắc: " + color);
        }
    }
}
