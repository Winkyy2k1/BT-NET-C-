using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proeject62
{
    class Vehicles : IVehicle , IComparable
    {
        private String id;
        private String maker; // hãng sản xuất
        private String model; // model, tên xe
        private int year; // năm sản xuất
        private double price; // giá tiền

        public Vehicles()
        {
         
        }
        public Vehicles(string id)
        {
            this.id = id;
        }
        public Vehicles(string id, string maker, string model, int year, double price)
        {
            this.id = id;
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public string Id { get => id; set => id = value; }
        public string Maker { get => maker; set => maker = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }
        public virtual void Input()
        {
            Console.WriteLine(" =======  INPUT ======= ");
            Console.Write("Nhập mã xe: ");
            id = Console.ReadLine();
            Console.Write("Nhập hãng sản xuất: ");
            maker = Console.ReadLine();
            Console.Write("Nhập tên xe: ");
            model = Console.ReadLine();
            Console.Write("Nhập năm sản xuất: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập giá tiền: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine(" ====== OUTPUT ===========");
            Console.WriteLine("Mã xe: " + id);
            Console.WriteLine("Hãng xe: " + maker);
            Console.WriteLine("Tên xe: " + model);
            Console.WriteLine("Năm sx: " + year);
            Console.WriteLine("Giá thành:" + price);
        }

        public override bool Equals(object obj)
        {
            Vehicles v = (Vehicles)obj;
            return (this.id.Equals(v.id));
        }
        public override string ToString()
        {
            return String.Format("{0,-10}{1,-15}{2,-10}{3,15}{4,15}", id, maker, model, year, price);
        }

        public int CompareTo(object obj)
        {
            Vehicles v = (Vehicles)obj;
            return (this.price.CompareTo(v.price));
        }
    }

    class SapXepNam : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return (x.Year - y.Year); // sắp xếp tăng dần
        }
    }
}
