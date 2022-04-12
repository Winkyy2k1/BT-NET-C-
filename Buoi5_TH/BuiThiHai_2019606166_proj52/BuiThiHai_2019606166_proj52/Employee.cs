using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_proj52
{
    class Employee
    {
        private string id;
        private string name;
        private int age;
        private int workingdays;
        private double salary;

        const int PRICE = 50;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Workingdays { get => workingdays; set => workingdays = value; }
        public double Salary { get  { return workingdays * PRICE; } }

        public Employee()
        {

        }

        public Employee(string id, string name, int age, int workingdays)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.workingdays = workingdays;
        }

        public void Input()
        {
            Console.WriteLine("Nhập thông tin nhân viên.");
           
            Console.WriteLine("Nhập mã nhân viên: ");
            id = Console.ReadLine();
            Console.WriteLine("Nhập tên nhân viên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi nhân viên: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số ngày làm việc của nhân viên: ");
            workingdays = Convert.ToInt32(Console.ReadLine());
        }

        void Output()
        {
            Console.WriteLine("Thông tin nhân viên là: ");
            Console.WriteLine("Mã nhân viên: " + id);
            Console.WriteLine("Tên: " + name );
            Console.WriteLine("Tuổi: " + age );
            Console.WriteLine("Ngày công: " + workingdays );
            Console.WriteLine("Lương: " + Salary );

        }

        //class UseEmployee
        //{
        //    public static void Main(string[] args)
        //    {
        //        Console.WriteLine(" Thông tin nhân viên là: \n");
        //        Employee e = new Employee();
        //        e.Input();
        //        e.Output();
        //    }
        //}


    }

        


}
