using System;
using System.Collections.Generic;

namespace C2_BuiThiHai_2019606166_DE01
{
    class Program
    {
        static List<ThiSinhUT> li = new List<ThiSinhUT>();
        // kiem tra id da ton tai hay chua. co => return true, khong => return false
        static Boolean checkId(string sbd)
        {
            foreach (var item in li)
            {
                if (string.Compare(item.Sbd, sbd) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
           
            int chon = 0;
            do
            {
                Console.WriteLine("\t ===== MENU ===== ");
                Console.WriteLine("\t 1. Nhập thêm thông tin 1 thí sinh.");
                Console.WriteLine("\t 2. Hiển thị thông tin toàn bộ các thí sinh.");
                Console.WriteLine("\t 3. Hiển thị thông tin sắp xếp theo điểm thi.");
                Console.WriteLine("\t 4. Danh sách các thi sinh đã Thi tốt.");
                Console.WriteLine("\t 5. Danh sách các thi sinh có cùng khu vực ưu tiên");
                Console.WriteLine("\t 6. Tìm kiếm theo số báo danh.");
                Console.WriteLine("\t 7. Xoá thí sinh theo số báo danh.");
                Console.WriteLine("\t 8. Kết thíc chương trình.");
                Console.WriteLine("\t == HÃY NHẬP LỰA CHỌN CỦA BẠN: == ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        {
                            ThiSinhUT ts = new ThiSinhUT();
                          while(true)
                            {
                                ts.NhapThongTin();
                                if(!checkId(ts.Sbd))
                                {
                                    li.Add(ts);
                                    break;
                                }  
                                else
                                    Console.WriteLine(" Số báo danh vùa nhập đã tồn tại, hãy nhập lại.");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("HIỂN THỊ DANH SÁCH THÍ SINH");
                            Console.WriteLine("{0, 5}{1, 10}{2,10}{3,5}{4,5}{5,5}{6,5}{7,5}", "SBD", "Họ Tên", "Toán", "Lý", "Hoá", "Khu vực", "Điểm UT", "Tổng điểm");
                            foreach (var item in li)
                            {
                                item.HienThi();
                            }
                            break;
                        }
                    case 3:
                        {
                            li.Sort();
                            Console.WriteLine("DANH SÁCH THÍ SINH SẮP XẾP THEO TỔNG ĐIỂM. ");
                            Console.WriteLine("{0, 5}{1, 10}{2,10}{3,5}{4,5}{5,5}{6,5}{7,5}", "SBD", "Họ Tên", "Toán", "Lý", "Hoá", "Khu vực", "Điểm UT","Tổng điểm");
                            foreach (var item in li)
                            {
                                item.HienThi();
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write(" Nhập điểm sàn: ");
                            float diemsan = float.Parse(Console.ReadLine());
                            Console.WriteLine("DANH SÁCH THÍ SINH THI ĐỖ LÀ.");
                            Console.WriteLine("{0, 5}{1, 10}{2,10}{3,5}{4,5}{5,5}{6,5}{7,5}", "SBD", "Họ Tên", "Toán", "Lý", "Hoá", "Khu vực", "Điểm UT", "Tổng điểm");
                            foreach (var item in li)
                            {
                                if (item.XetTuyen(diemsan) == "Thi đỗ") item.HienThi();
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write(" Nhập khu vực ưu tiên ( 1-3): ");
                            int khuvuc = int.Parse(Console.ReadLine());
                            Console.WriteLine("DANH SÁCH THÍ SINH CÓ CÙNG KHU VỰC: ");
                            Console.WriteLine("{0, 5}{1, 10}{2,10}{3,5}{4,5}{5,5}{6,5}{7,5}", "SBD", "Họ Tên", "Toán", "Lý", "Hoá", "Khu vực", "Điểm UT", "Tổng điểm");
                            foreach (var item in li)
                            {
                                if (item.khuvuc == khuvuc) item.HienThi();
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Nhập sbd thí sinh muốn tìm: ");
                            string sbd = Console.ReadLine();
                            bool check = false;
                            foreach (var item in li)
                            {
                                if (item.Sbd == sbd)
                                {
                                    Console.WriteLine("Tìm thấy sinh viên có sbd: " + sbd +" thông tin là:");
                                    Console.WriteLine("{0, 5}{1, 10}{2,10}{3,5}{4,5}{5,5}{6,5}{7,5}", "SBD", "Họ Tên", "Toán", "Lý", "Hoá", "Khu vực", "Điểm UT", "Tổng điểm"); 
                                    item.HienThi();
                                }
                            }
                            if(check == false)
                                Console.WriteLine(" Không tìm thấy sbd đó. ");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Nhập sbd thí sinh muốn xoá: ");
                            string sbd = Console.ReadLine();
                            bool check = false;
                            for( int i=0; i<li.Count; i++)
                            {
                                if (li[i].Sbd.Equals(sbd))
                                {
                                    check = true;
                                    li.RemoveAt(i);
                                }
                            }
                            if (check == false)
                                Console.WriteLine(" Không tìm thấy sbd đó. ");
                            else
                            {
                                Console.WriteLine("DANH SÁCH THÍ SINH SAU XOÁ LÀ: ");
                                Console.WriteLine("{0, 5}{1, 10}{2,10}{3,5}{4,5}{5,5}{6,5}{7,5}", "SBD", "Họ Tên", "Toán", "Lý", "Hoá", "Khu vực", "Điểm UT", "Tổng điểm");
                                foreach (var item in li)
                                {
                                    item.HienThi();
                                }
                            } 
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("\t Kết thúc chương trình.");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Hãy nhập một số từ 1-8!");
                            break;
                        }
                }
            } while (chon!= 8);
        }
    }
}
