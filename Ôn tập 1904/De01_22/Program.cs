using System;
using System.Collections.Generic;
using System.Text.Encodings;
namespace De01_22
{
    class Program
    {
        static List<Employee> li = new List<Employee>();
        static void Main(string[] args)
        {
            int opt;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                Console.WriteLine("1:Thêm nhân viên");
                Console.WriteLine("2:Hiển thị danh sách nhân viên");
                Console.WriteLine("3:Xóa nhân viên");
                Console.WriteLine("4:Kết thúc");
                Console.WriteLine("===choose===");
                opt = int.Parse(Console.ReadLine());
                switch(opt)
                {
                    case 1:
                        addEmployee();
                        break;
                    case 2:
                        show();
                        break;
                    case 3:
                        //deteteEmployeebyID();
                        SortBySalary();
                        break;
                }    
            }
            while (opt != 4);
            static void addEmployee()
            {
                try
                {
                    Employee nv = new Employee();
                    nv.Input();
                    if (li.Count==0)
                    {
                        li.Add(nv);
                    }
                    else
                    {
                        while(li.IndexOf(nv)!=-1)
                        {
                            Console.WriteLine("Mã nhân viên này đã tồn tại!");
                            Console.WriteLine("Nhập lại:");
                            nv.Input();
                        }
                        li.Add(nv);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("lỗi:"+e.Message);
                }
            }
            static void inTieuDe()
            {
                string s=String.Format("{0,-8}{1,-16}{2,-24}{3,10}{4,15}{5,20}", "id", "Fname", "Age", "Working day", "Salary", "Thuong");
                Console.WriteLine(s);
            }
            static void show()
            {
                inTieuDe();
                foreach(var item in li)
                {
                    Console.WriteLine(item);
                }  
            }
            static void deteteEmployeebyID()
            {
                Console.WriteLine("nhập id cần xóa:");
                int id = int.Parse(Console.ReadLine());
                int chon;
                do
                {
                    Employee nv = new Employee(id);
                    int index = li.IndexOf(nv);
                    Console.WriteLine("Bạn chắc chắn muốn xóa nhân viên này không?");
                    Console.WriteLine("1:Yes");
                    Console.WriteLine("2:No");
                    Console.WriteLine("chọn:");
                    chon = int.Parse(Console.ReadLine());
                    if (chon == 1)
                    {
                        if (index != -1)
                        {
                            li.RemoveAt(index);
                            show();
                        }
                        else
                        {
                            Console.WriteLine("không tồn tại mã id này");
                            break;
                        }
                    }

                }
                while (chon != 2);
            }
            static void SortBySalary()
            {
                Console.WriteLine("truoc khis sap xep:");
                show();
                li.Sort();
                Console.WriteLine("Sau khis sap xep:");
                show();
            }
        }
    }
}
