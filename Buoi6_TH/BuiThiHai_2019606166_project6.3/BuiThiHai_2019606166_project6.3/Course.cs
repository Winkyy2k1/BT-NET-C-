using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_project6._3
{
    class Course  // Khoá học
    {
        public string courseid { get; set; }
        public string courseName { get; set; }
        public int fee { get; set; }

        public Course(string courseid)
        {
            this.courseid = courseid;
        }

        public Course(string courseid, string courseName, int fee)
        {
            this.courseid = courseid;
            this.courseName = courseName;
            this.fee = fee;
        }

        public List<Student> listStd { get; set; }
        public Course()
        {
            List<Student> li  = new List<Student>();
        }
        public void InputCourse() // nhập dữ liêju cho 3 thuộc tính của lớp Course và ds lớp sinh viên listStd
        {
            Console.WriteLine("Nhập mã khoá học: ");
            courseid = Console.ReadLine();
            Console.WriteLine("Nhập tên khoá học: ");
            courseName = Console.ReadLine();
            Console.WriteLine("Nhập học phí khoá học: ");
            fee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập danh sách snh viên: ");
            Console.WriteLine("Nhập số lương sinh viên: ");
            int n = Convert.ToInt32(Console.ReadLine());
            listStd = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Student s = new Student();
                s.InputStudent();
                listStd.Add(s);
            }
        }

        public void DisplayCourseAndStudents()
        {
            
            Console.WriteLine(" Mã KH: " + courseid + " Tên KH: " + courseName + " Học phí: " + fee);
            Console.WriteLine(" ===== DANH SÁCH SINH VIÊN CỦA KHOÁ HỌC NÀY ===== ");
            Console.WriteLine(" {0,5}{1,10}{2,10}", "Mã SV ", " Tên SV ", "Điểm ");
            foreach (var item in listStd)
            {
                Console.WriteLine(item);
            }

        }

        public List<Student> GetAllStudent() => listStd;

       

        public override int GetHashCode()
        {
            return HashCode.Combine(courseid);
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   courseid == course.courseid;
        }

        //public override bool Equals(object obj)
        //{   Course c = (Course)obj;
        //    return (this.courseid.Equals(c.courseid));
        //}


    }
}
