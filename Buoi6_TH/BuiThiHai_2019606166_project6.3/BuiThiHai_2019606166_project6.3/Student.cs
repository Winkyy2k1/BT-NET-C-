using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_project6._3
{
    class Student
    {
        public int studentid {get; set;}
        public string name {get; set;}
        public string mark {get; set;}

        public Student()
        {

        }

        public Student(int studentid)
        {
            this.studentid = studentid;
        }

        public Student(int studentid, string name, string mark)
        {
            this.studentid = studentid;
            this.name = name;
            this.mark = mark;
        }

        public override string ToString()
        {
            return String.Format("{0,5}{1,10}{2,10}", studentid, name, mark);
        }

        public void InputStudent()
        {
            Console.WriteLine("NHẬP DỮ LIỆU CHO 3 THUỘC TÍNH ");
            Console.Write(" Nhập mã sinh viên");
            studentid = int.Parse(Console.ReadLine());
            Console.Write(" Nhập tên sinh viên");
            name = Console.ReadLine();
            Console.Write(" Nhập điểm sinh viên");
            mark = Console.ReadLine();

        }

        //public override bool Equals(object obj)
        //{
        //    return obj is Student student &&
        //           studentid == student.studentid;
        //}

        public override bool Equals(object obj)
        {
            Student st = (Student)obj;
            return (this.studentid.Equals(st.studentid));
        }


    }
}
