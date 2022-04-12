using System;
using System.Collections.Generic;

namespace BuiThiHai_2019606166_proj61
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> li = new List<Student>();
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Bài thực hành buổi 6 - Proeject 6.1 \n");
            int chon = 0;
            do
            {    
                Console.WriteLine("Các lựa chọn: ");
                Console.WriteLine("Chọn 1: Thêm 1 sinh viên");
                Console.WriteLine("Chọn 2: Hiển thị danh sách các sinh viên");
                Console.WriteLine("Chọn 3: Tìm kiếm theo id");
                Console.WriteLine("Chọn 4: Tìm kiếm theo adress");
                Console.WriteLine("Chọn 5: Xoá 1 sinh viêntheo id");
                Console.WriteLine("Chọn 6: Kết thúc chương trình");
                Console.WriteLine("\n Nhập lựa chọn của bạn ! ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            Console.WriteLine("Thêm 1 sinh viên:");
                            li.Add(new Student(1, "Hai", "HY", 10, 10));
                            li.Add(new Student(2, "Anh", "HN", 8, 9));
                            li.Add(new Student(3, "Trang", "HNam", 7, 8));
                            //Console.WriteLine("Nhập 1 sinh viên");
                            //Student Stu;
                            //    Stu = new Student();
                            //    Stu.Input();
                            //    li.Add(Stu);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Danh sách sinh viên là: ");
                            foreach (var item in li)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 3:
                        {   // Tìm kiếm sinh vien theo id
                            Console.WriteLine("Nhâp id cần tìm: ");
                            int id_tim = Convert.ToInt32(Console.ReadLine());
                            List<Student> li3 = new List<Student>();
                            foreach (var item in li)
                            {
                                if (item.id.Equals(id_tim))
                                {
                                    li3.Add(item);
                                }
                            }
                            if (li3.Count > 0)
                            {
                                Console.WriteLine("Những sinh viên có id:  "+ id_tim + " là:  ");
                                foreach (var item in li3)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else Console.WriteLine(" Không tìm thấy id này");
                            break;
                        }
                    case 4:
                        {   // Tìm kiếm sinh viên theo address
                            Console.WriteLine("Nhâp dia chỉ cần tìm: ");
                            string add = Console.ReadLine();
                            List<Student> li2 = new List<Student>();
                            foreach (var item in li)
                            {   
                                if(item.address.Equals(add))
                                {
                                    li2.Add(item);
                                }    
                            }
                            if(li2.Count>0)
                            {
                                Console.WriteLine("Những sinh viên có địa chỉ: " + add + " là:  ");
                                foreach (var item in li2)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else Console.WriteLine("Không tìm thấy sinh viên có địa chỉ này.");

                            break;
                        }
                    case 5:
                        {   // Xoá 1 sinh viên theo id
                            Console.WriteLine("Nhâp id cần xoá: ");
                            int id_tim = Convert.ToInt32(Console.ReadLine());
                            int index = -1;
                            foreach (var item in li)
                            {
                                if (item.id.Equals(id_tim))
                                {
                                    index = li.IndexOf(item);
                                    Console.WriteLine(" vị trí là: " + index);
                                }
                   
                            }
                            if( index != -1)
                            {
                                li.RemoveAt(index);
                                Console.WriteLine("Danh sách sau xoá là: ");
                                foreach (var item in li)
                                {
                                    Console.WriteLine(item);
                                }

                            }
                            else Console.WriteLine("Không tìm phấy sinh viên muốn xoá");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(" Kết thúc chương trình");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("\t \t Hãy lựa chọn 1 số từ 1 đến 6");
                            break;
                        }
                }    

            } while (chon !=6);
        }

        public void Nhap()
        {

        }

    }
}
