using System;
using System.Collections.Generic;

namespace Bai6_Phieu2
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon = 0;
            List<Vehicles> li = new List<Vehicles>();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;  

            do
            {
                Console.WriteLine(" === MENU === ");
                Console.WriteLine(" 1. Nhập dữ liệu ");
                Console.WriteLine(" 2. Hiển thị dữ liệu ");
                Console.WriteLine(" 3. Tìm kiếm theo id ");
                Console.WriteLine(" 4. Tìm kiếm theo maker ");
                Console.WriteLine(" 5. Sắp xếp theo price ");
                Console.WriteLine(" 6. Sắp xếp theo year ");
                Console.WriteLine(" 7. Kết thúc ");

                Console.WriteLine("Nhập lựa chọn của bạn: ");
                chon = int.Parse(Console.ReadLine());

                switch(chon)
                {
                    case 1:
                        {
                            Console.WriteLine(" Nhập dữ liệu cho CAR ");
                            li.Add(new Car("Car1","Mes","123",2000, 2019,"blue"));
                            li.Add(new Car("Car2","Audi","113",5000, 2009,"blue"));
                            li.Add(new Car("Car3","As","223",7000, 2013,"blue"));
                            Console.WriteLine(" Nhập dữ liệu cho TRUCK ");
                            li.Add(new Truck("Truck1", "Toyota", "223", 7000, 2020, 15));
                            li.Add(new Truck("Truck2", "Audi", "223", 7000, 2022, 36));
                            li.Add(new Truck("Truck3", "Yamaha", "223", 7000, 2017, 55));
                            break;
                        }
                    case 2:
                        {
                            foreach (var item in li)
                            {
                                item.Output();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Nhập id cần tìm kiếm: ");
                            string id = Console.ReadLine();
                            bool check = false;
                            foreach (var item in li)
                            {
                                if (item.id.Equals(id))
                                {
                                    check = true;
                                    Console.WriteLine("Tìm thấy xe là: "  );
                                    item.Output();
                                }
                            }
                            if (check == false) Console.WriteLine(" Không tìm thấy id đó");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Nhập marker cần tìm kiếm: ");
                            string marker = Console.ReadLine();
                            bool check = false;
                            foreach (var item in li)
                            {
                                if (item.maker.Equals(marker))
                                {
                                    check = true;
                                    Console.WriteLine("Tìm thấy xe có marker đó là: ");
                                    item.Output();
                                }
                            }
                            if (check == false) Console.WriteLine(" Không tìm thấy marker đó");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Danh sách trước sắp xếp là:");
                            
                            var header = String.Format("{0,-10}{1,10}{2,10}{3,10}{4,10}", "id", "maker", "model", "year", "price");
                            Console.WriteLine(header);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item); 
                            }
                            li.Sort();
                            Console.WriteLine("Danh sách sau sắp xếp theo price là: ");
                            Console.WriteLine(header);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Danh sách trước sắp xếp là:");

                            var header2 = String.Format("{0,-10}{1,10}{2,10}{3,10}{4,10}", "id", "maker", "model", "year", "price");
                            Console.WriteLine(header2);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            li.Sort(new Vehicles1());
                            Console.WriteLine("Danh sách sau sắp xếp theo year là: ");
                            Console.WriteLine(header2);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            break;
 
                        }
                    case 7:
                        {
                            Console.WriteLine(" Kết thúc chương trình.");
                            return;
                        }
                }    
            }
            while (chon != 7);
        }
    }
}
