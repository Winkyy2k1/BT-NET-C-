using System;
using System.Collections.Generic;

namespace BuiThiHai_2019606166_proeject62
{
    class Program
    {   public static void Menu()
        {
            Console.WriteLine("Mời bạn lựa chọn 1 số: ");
            Console.WriteLine("1. Nhập dữ liệu ");
            Console.WriteLine("2. Hiển thị dữ liệu ");
            Console.WriteLine("3. Tìm kiếm theo id ");
            Console.WriteLine("4. Tìm kiếm theo marker ");
            Console.WriteLine("5. Sắp xếp theo price ");
            Console.WriteLine("6. Sắp xếp theo year ");
            Console.WriteLine("7. Kết thúc ");
        }

        static void Main(string[] args)
        {
            var header = String.Format("{0,-10}{1,-15}{2,-10}{3,15}{4,15}", " Mã xe", "Hãng sx", "Tên xe", " Năm sx", " Giá");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Bài 6. Phiếu bài tập 2 - Project 6.2 ");
            int chon = 0;
            List<Vehicles> li = new List<Vehicles>();
            do
            {
                Menu();
                Console.Write(" ================= Nhập lựa chọn của bạn.================= ");
                chon = int.Parse(Console.ReadLine());
              
                switch (chon)
                {
                    case 1:
                        {   // Thêm 3 thông tin cho car

                            li.Add(new Car("Xe1", "Honda", "Xe1", 2019, 10000,"blue"));
                            li.Add(new Car("Xe2", "Toyota", "Xe2", 2021, 15000,"red"));
                            li.Add(new Car("Xe3", "Huyndai", "Xe3", 2020, 18000,"black"));

                            // Thêm 3 thông tin cho truck
                            li.Add(new Truck("Xe4", "Honda", "Xe4", 2022, 19000, 400));
                            li.Add(new Truck("Xe5", "Toyota", "Xe5", 2021, 11000, 650));
                            li.Add(new Truck("Xe6", "Huyndai", "Xe6", 2016, 8000, 500));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("=================  Danh sách vừa nhập là: ================= ");
                           
                            Console.WriteLine(header);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 3:
                        {   // Tìm kiếm theo id.
                            Console.WriteLine("Nhập id cần tìm kiếm: ");
                            string id_tim = Console.ReadLine();
                            int dem = 0;
                            foreach (var item in li)
                            {
                                if(item.Id.Equals(id_tim))
                                    {
                                    dem++;
                                    }
                               
                            }
                            if (dem > 0 )
                            {
                                foreach (var item in li)
                                    if (item.Id.Equals(id_tim))
                                    {
                                        Console.WriteLine("Tìm thấy xe: " + item);
                                    }
                            }
                            else
                                Console.WriteLine(" không có id" + id_tim + " trong danh sach xe. ");
                            break;
                        }
                    case 4:
                        {   //  // Tìm kiếm theo marker.
                            Console.WriteLine("Nhập marker ( Hãng sản xuấ) cần tìm kiếm: ");
                            string marker_tim = Console.ReadLine();
                            // Tạo một ds 2 để lưu nhũng item có marker banwgf marker cần tìm
                            List<Vehicles> li2 = new List<Vehicles>();
                            foreach (var item in li)
                            {
                                if (item.Maker.Equals(marker_tim))
                                    li2.Add(item);
                            }
                           if(li2.Count>0)
                            {
                                Console.WriteLine(" Tìm thấy xe: ");
                                foreach (var item in li2)
                                {
                                    Console.WriteLine(item);
                                }
                            }  else
                            {
                                Console.WriteLine(" Không tìm thấy xe nào của hãng sản xuất " + marker_tim);
                            }    
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(" DANH SÁCH TRƯỚC KHI SẮP XẾP LÀ");
                            Console.WriteLine(header);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine(" DANH SÁCH TRƯỚC SAU SẮP XẾP THEO GIÁ LÀ");
                            li.Sort();
                            Console.WriteLine(header);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }

                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(" DANH SÁCH TRƯỚC KHI SẮP XẾP LÀ");
                            Console.WriteLine(header);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine(" DANH SÁCH TRƯỚC SAU SẮP XẾP THEO NĂM SẢN XUẤT LÀ");
                            li.Sort(new SapXepNam());
                            Console.WriteLine(header);
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine(" ================= Kết thúc chương trình! ==================="); ;
                            return;
                        }
                    default: 
                        {
                            Console.WriteLine(" =================  Hãy nhập 1 só từ 1 đến 7  =================  ");
                            break;
                        }
                  
                }

            } while (chon != 7);

        }
        
    }
}
