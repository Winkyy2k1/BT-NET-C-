using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_pj4
{
    class Student
    {
        private string _id;
        private string _name;
        private int _mark;
        private int _scholarship;

        public string id { get; set; }
        public string name { get; set; }
        public int mark { get; set; }
        public int scholarship { 
            get { return _scholarship ; }
            set
            {
                if (_mark > 8) _scholarship= 500;
                else
                if (_mark >= 7 && _mark <= 8)
                        _scholarship = 300;
                    else _scholarship = 0;
             }
        }
        public Student()
        {
            id = "011";
            name = " Nguyen van A";
            mark = 9;
           
        }
        // Pt khoi tao 1 tham so id
        public Student(string id)
        {
            this.id = id;
        }
        public Student(string id, string name, int mark, int scholraship)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }
        public static void Main(string[] args)
        {   
            Student s1 = new Student ("012", "Anaa", 8, 9);
        }

    }
}
