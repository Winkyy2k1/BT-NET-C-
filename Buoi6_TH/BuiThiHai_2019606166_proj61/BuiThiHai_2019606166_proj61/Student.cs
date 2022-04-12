using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proj61
{
    class Student:Person
    {
        protected byte maths { get; set; }   // toán
        protected byte physics { get; set; } // lý

        public Student():base()
        {

        }

        public Student(int id, string name, string address,byte maths, byte physics) : base(id, name, address)
        {
            this.maths = maths;
            this.physics = physics;
        }

        public override void Input()
        {
            base.Input();
            // Thêm nhập của hai thuộc tính maths và physics.
            Console.WriteLine("Nhập điểm toán: ");
            maths = (byte)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập điểm lý: ");
            physics = (byte)Convert.ToInt32(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("{0,5}{1, 5}",maths, physics);
        }
        public int Total()
        {
            return maths + (physics + maths);
        }
        public override string ToString()
        {
            return ("ID: " + id + " - Name: " + name + " - Đia chi: " + address + " - Diem toan: " + maths + " - Diem ly: " + physics);
        }
     
        public override bool Equals(object obj)
        {
            Student sv = (Student)obj;
            return (this.id.Equals(sv.id));
        }

    }
}
