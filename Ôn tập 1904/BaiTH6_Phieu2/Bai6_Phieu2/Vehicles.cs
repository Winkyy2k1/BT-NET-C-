using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_Phieu2
{
    class Vehicles:IVehicle, IComparable
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public double price { get; set; }
        public Vehicles()
        {

        }

        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void Input()
        {
            Console.WriteLine("NHẬP DỮ LIỆU CHO XE: ");
            Console.WriteLine(" Nhập mã định danh: ");
            id = Console.ReadLine();
            Console.WriteLine(" Nhập hãng sản xuất: ");
            maker = Console.ReadLine();
            Console.WriteLine("Nhập tên xe: ");
            model = Console.ReadLine();
            Console.WriteLine("Nhập năm sản xuất: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá tiền: ");
            price = double.Parse(Console.ReadLine());

           
        }

        public virtual void Output()
        {
            Console.WriteLine(" ===== OUTPUT ===== ");
            Console.WriteLine(" Mã xe: " + id);
            Console.WriteLine(" Hãng SX: " + maker);
            Console.WriteLine(" Tên xe: " + model);
            Console.WriteLine(" Năm SX: " + year );
            Console.WriteLine(" Giá tiền: " + price );
           
        }

        public override bool Equals(object obj)
        {
            Vehicles v = (Vehicles)obj;
            return (this.id.Equals(v.id));
        }

        public override string ToString()
        {
            return String.Format("{0,-10}{1,10}{2,10}{3,10}{4,10}", id, maker, model, year, price);

        }

        public int CompareTo(object obj)
        {
            Vehicles v = (Vehicles)obj;
            return (this.price.CompareTo(v.price));
        }
    }

    class Vehicles1 : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return (x.year - y.year);
        }
    }
}
