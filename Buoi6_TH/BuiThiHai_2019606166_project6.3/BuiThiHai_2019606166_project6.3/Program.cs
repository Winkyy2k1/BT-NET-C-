using System;
using System.Collections.Generic;

namespace BuiThiHai_2019606166_project6._3
{
    class Program
    {

        // static List<Course> ds = new List<Course>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;  
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            Console.WriteLine("Bài thực hành 6, phiếu số 3");
            List<Course> ds = new List<Course>();
            while (true)
            {
                Console.WriteLine(" ĐÂY LÀ MENU - HÃY LỰA CHỌN !");
                Console.WriteLine("1. Thêm một khoá học. ");
                Console.WriteLine("2. Hiển thị các khoá học. ");
                Console.WriteLine("3. Tìm kiếm khoá học. ");
                Console.WriteLine("4. Tìm kiếm sinh viên. ");
                Console.WriteLine("5. Xoá một khoá học. ");
                Console.WriteLine("6. Kết thúc chương trình. ");
                Console.WriteLine(" Hãy  nhập lựa chọn của bạn: ");
                int chon = Convert.ToInt32(Console.ReadLine());
                    switch(chon)
                {
                    case 1:
                        {
                            Console.WriteLine(" \t Bạn đã chọn thêm 1 khoá học. ");
                            Course x = new Course();
                            x.InputCourse();
                            ds.Add(x);
                           
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\t Bạn đã chọn hiển thị các khoá học. ");
                            Console.WriteLine(" ===== DANH SÁCH KHOÁ HỌC ===== ");
                            foreach (var item in ds)
                            {   
                                item.DisplayCourseAndStudents();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\t Bạn đã chọn Tìm kiếm khoá học. ");
                            Console.Write(" Nhập mã khoá học cần tìm: ");
                            string couse_byId = Console.ReadLine();
                            bool check = false;
                            foreach (Course item in ds)
                            {
                                if(item.courseid.Equals(couse_byId))
                                {
                                    check = true;
                                    Console.Write(" \t \t Tìm thấy khoá học là: ");
                                    item.DisplayCourseAndStudents();
                                }   
                            }
                            if( check == false) Console.WriteLine(" \t \t Không tìm thấy id khoá học muốn tìm kiếm. ");
                            break;
                        }
                    case 4:
                    {
                        Console.WriteLine(" \t Bạn đã chọn Tìm kiếm sinh viên ");

                            Console.Write(" Nhập mã sinh viên cần tìm: ");
                            string stu_byId = Console.ReadLine();
                            bool check2 = false;
                            foreach  (Course x in ds)
                            {
                                foreach (Student item in x.listStd)
                                {
                                    if (item.studentid.Equals(stu_byId))
                                    {
                                        check2 = true;
                                        Console.Write(" \t \t Tìm thấy sinh viên là: ");
                                        Console.WriteLine(" {0,5}{1,10}{2,10}", "Mã SV ", " Tên SV ", "Điểm ");
                                        Console.WriteLine(item);
                                    }
                                }
                            }

                            if (check2 == false) Console.WriteLine("Không tìm thấy sinh viên có mã" + stu_byId );
                            //else Console.WriteLine("\n \t Không tìm thấy khoá học.");
                            break;
                    }
                    case 5:
                    {
                        Console.WriteLine("\t Bạn đã chọn Xoá 1 khoá học ");

                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("\t Kết thúc chương trình ");
                        return;
                    }
                    default:
                        {
                            Console.WriteLine(" HÃY NHẬP MỘT SỐ TỪ 1 ĐẾN 6. ");
                            break;
                        }

                }    
            }    
        }
    }
}
