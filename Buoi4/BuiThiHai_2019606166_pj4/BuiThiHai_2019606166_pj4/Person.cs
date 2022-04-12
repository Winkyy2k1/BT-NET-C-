using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiThiHai_2019606166_pj4
{
    class Person
    {
        private string _id;
        private string _name;
        private int _age;
        private string _email;
        private string _address;

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age  { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public void CheckAge()
        {
            if (Age >= 18) Console.WriteLine("Bạn đủ tuổi bầu cử !");
            else Console.WriteLine("Bạn còn nhỏ.");
        }
        public void Input()
        {
            Console.Write("Nhap id: ");
            Id = Console.ReadLine();
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap email: ");
            Email = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            Address = Console.ReadLine();

        }
        
        public void Output()
        {
            Console.WriteLine("Id la: " + Id);
            Console.WriteLine("Name la: " + Name);
            Console.WriteLine("Age la: " + Age);
            Console.WriteLine("Email la: " + Email);
            Console.WriteLine("Address la: " + Address);
        }
        //static void Main1(string[] args)
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;  
        //    Console.InputEncoding = System.Text.Encoding.UTF8; 
        //    Person p = new Person();
            
        //    Console.WriteLine("Nhap mot nguoi: ");
        //    p.Input();
        //    Console.WriteLine("\n In thong tin ra man hinh: ");
        //    p.Output();
        //    Console.WriteLine("\n Kiem tra tuoi nguoi do: ");
        //    p.CheckAge();

        //}
    }
}
