using System;
using System.Collections.Generic;
using System.Text;

namespace Phieu3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<Course> ListCourses = new List<Course>();
            while(true)
            {
                Console.WriteLine("Mời nhập lựa chọn\n1.Thêm 1 khóa học\n2.Hiển thị các khóa học\n3.Tìm kiếm khóa học\n" +
                    "4.Tìm kiếm sinh viên\n5.Xóa 1 khóa học\n6.Kết thúc chương trình !");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        AddACourse(ref ListCourses);
                        break;
                    case 2:
                        DisplayCourses(ref ListCourses);
                        break;
                    case 3:
                        SearchByID(ref ListCourses);
                        break;
                    case 4:
                        SearchASudentByID(ref ListCourses);
                        break;
                    case 5:
                        RemoveACourse(ref ListCourses);
                        break;
                    case 6:
                        return;
                }
            }    
        }
        public static void AddACourse(ref List<Course> ListCourses)
        {
            Course x=new Course();
            x.InputCource();
            ListCourses.Add(x);
        }
        public static void DisplayCourses(ref List<Course> ListCourses)
        {
            foreach(Course x in ListCourses)
            {
                Console.WriteLine("===============Danh sách các khóa học là =================");
                Course.InTieuDe();
                x.DisplayCourceAndStudents();
            }
        }
        public static void SearchByID(ref List<Course> ListCourses)
        {
            Console.WriteLine("Nhập ID khóa học cần tìm kiếm :");
            String id = Console.ReadLine();
            bool check = false;
            foreach (Course x in ListCourses)
            {
                if (x.CourseId.Equals(id)) 
                { 
                    check = true;
                    x.DisplayCourceAndStudents();
                }
            }
            if (check == false)
            {
                Console.WriteLine("không có khóa học có id là :"+id);
            }

        }
        public static void SearchASudentByID(ref List<Course> ListCourses)
        {
            Console.WriteLine("Nhập ID sinh viên cần tìm kiếm :");
            String id = Console.ReadLine();
            bool check = false;
            foreach (Course x in ListCourses)
            {
                foreach(Student y in x.ListStd)
                {
                    if (y.StudentId.Equals(id))
                    {
                        check = true;
                        y.ToString();
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine("không có sinh vien có id là :" + id);
            }
        }
        public static void RemoveACourse(ref List<Course> ListCourses)
        {
            Console.WriteLine("Nhập ID khóa học cần xóa :");
            String id = Console.ReadLine();
            bool check = false;
            foreach (Course x in ListCourses)
            {
                if (x.CourseId.Equals(id))
                {
                    check = true;
                    ListCourses.Remove(x);
                }
            }
            if (check == false)
            {
                Console.WriteLine("không có khóa học có id là :" + id);
            }

        }
    }
}
