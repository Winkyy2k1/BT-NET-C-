using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phieu3
{
    class Course
    {
        public String CourseId { get; set; }
        String CourseName { get; set; }
        int Fee { get; set; }
        public List<Student> ListStd ;
        public Course() {
            ListStd = new List<Student>();
        }
        public void InputCource()
        {
            Console.Write("nhap CourceId :");
            CourseId = Console.ReadLine();
            Console.Write("nhap CourceName :");
            CourseName = Console.ReadLine();
            Console.Write("nhap fee :");
            Fee = int.Parse(Console.ReadLine());
            Console.Write("nhap so luong student :");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Student x=new Student();
                x.InputStudent();
                ListStd.Add(x);
            }
        }
        public static void InTieuDe()
        {
            Console.Write(String.Format("{0,-20} {1,-15}{2,-15}\n", "CourseId", "CousceName", "Fee"));
        }
        public void DisplayCourceAndStudents()
        {
            Console.Write(String.Format("{0,-20} {1,-15}{2,-15}\n", CourseId, CourseName, Fee));
            Console.WriteLine("\t\t=======Danh sách sinh viên trong khóa học " + CourseId + " là :========");
            Student.InTieuDe();
            
            foreach(Student x in ListStd)
            {
                Console.WriteLine(x);
            }
        }
        public List<Student> GetAllStudents()
        {
            return ListStd;
        }

    }
}
