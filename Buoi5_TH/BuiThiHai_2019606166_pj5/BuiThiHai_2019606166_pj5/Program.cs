using System;
using System.Collections.Generic;
    

namespace BuiThiHai_2019606166_pj5
{
    class Program
    {
        private static List<ThiSinhA> li = new List<ThiSinhA>();
        
        private static ThiSinhA thiSinh;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t \t Bài toán Thi Sinh - project 5");
            string chon = "";
             Menu();  
        }

        static void Menu()
        {
            int chon;
            string ck;
            do
            {
                Console.WriteLine("Các lựa chọn: ");
                Console.WriteLine("Chọn 1: Nhập thông tin 1 thí sinh");
                Console.WriteLine("Chọn 2: Hiển thị danh sách các thí sinh");
                Console.WriteLine("Chọn 3: Hiển thị danh sách các thí sinh theo tổng điểm");
                Console.WriteLine("Chọn 4: Hiển thị danh sách các thí sinh theo địa chỉ");
                Console.WriteLine("Chọn 5: Tìm kiếm theo số báo danh");
                Console.WriteLine("Chọn 6: Kết thúc chương trình");
               
                Console.WriteLine("\n Nhập lựa chọn của bạn ! ");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            // Nhập thông tin 1 thí sinh
                            Nhap1TS();
                            break;
                        }
                    case 2:
                        {
                            // Hiển thị danh sách các thí sinh
                            HienThiDS();
                            break;
                        }
                    case 3:
                        {
                            // Hiển thị danh sách các thí sinh theo tổng điểm
                            HienThiDSTheoTongDiem();
                            break;
                        }
                    case 4:
                        {
                            //  Hiển thị danh sách các thí sinh theo địa chỉ
                            HienThiDSTheoDiaChi();
                            break;
                        }
                    case 5:
                        {
                            // Tìm kiếm theo số báo danh
                            TKTheoSBD();
                            break;
                        }
                    case 6:
                        {
                            // Kết thúc chương trình
                            Console.WriteLine("\t \t Chương trình đã chạy và kết thúc.");
                            return; 
                        }
                    default:
                        {
                            Console.WriteLine("\t \t Hãy lựa chọn 1 số từ 1 đến 6");
                            break;
                        }
                }

                Console.WriteLine("Bạn có muốn tiếp tục thực hiện không? (c/k) ");
                ck = Console.ReadLine();
                if (ck == "k")
                {
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                }
            } while (chon < 0 || chon > 6 || ck != "k");
        }

        static void Nhap1TS()
        {
            thiSinh = new ThiSinhA(); // Khởi tạo đối tượng mới.
                Console.Write("Nhập số báo danh: ");
                thiSinh.Id = Console.ReadLine();
                Console.Write("Nhập họ tên: ");
                thiSinh.Name = Console.ReadLine();
                Console.Write("Nhập địa chỉ: ");
                thiSinh.DiaChi = Console.ReadLine();
                Console.Write("Nhập điểm Toán: ");
                thiSinh.DiemToan = float.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Hoá: ");
                thiSinh.DiemHoa = float.Parse(Console.ReadLine());
                Console.Write("Nhập điểm Lý: ");
                thiSinh.DiemLy = float.Parse(Console.ReadLine());
                Console.Write("Nhập điểm ưu tiên: ");
                thiSinh.DiemUT = float.Parse(Console.ReadLine());
            li.Add(thiSinh);

        }
        static void NhapDSTS()
        {
            Console.WriteLine("Nhập số lượng thí sinh: ");
            int size = int.Parse(Console.ReadLine());
            for( int i=0; i<size; i++)
            {
                Console.WriteLine("Nhập thí sinh thứ " + (i+1));
                Nhap1TS();
              //  li.Add(thiSinh); // Thêm sinh viên vừa nhập vào cuối danh sách.
            }    
        }
        static void HienThiDS()
        {
            foreach (ThiSinhA item in li)
            {
                Console.WriteLine(item);
            }
        }
        static void HienThiDSTheoTongDiem()
        {
            Console.WriteLine("Nhập điểm dùng làm mốc: ");
            float DiemMoc = Convert.ToSingle(Console.ReadLine());
            int dem = 0;
            for(int i=0; i<li.Count; i++)
            {
                if(li[i].TongDiem >= DiemMoc )
                {
                    dem++;
                }    
            }
            if (dem == 0) Console.WriteLine("Không có thí sinh nào có điểm >= " + DiemMoc);
            else
            {
                Console.WriteLine("Danh sách các thí sinh có điểm >= " + DiemMoc + " là: \n");
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].TongDiem >= DiemMoc)
                    {
                        Console.WriteLine(li[i]);
                    }
                }
            } 
                
        }
        static void HienThiDSTheoDiaChi()
        {
            Console.WriteLine("Nhập điểm dùng làm mốc: ");
            string DiaChi = Console.ReadLine();
            int dem = 0;
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].DiaChi == DiaChi)
                {
                    dem++;
                }
            }
            if (dem == 0) Console.WriteLine("Không có thí sinh nào có địa chỉ ở " + DiaChi);
            else
            {
                Console.WriteLine("Danh sách các thí sinh có địa chỉ ở " + DiaChi + " là: \n");
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].DiaChi == DiaChi)
                    {
                        Console.WriteLine(li[i]);
                    }
                }
            }
        }
        static void TKTheoSBD()
        {
            Console.WriteLine("Nhập mã sv cần tìm: ");
            string tim = Console.ReadLine();
            int dem = 0;
            int index = -1;
            for(int i=0; i < li.Count; i++)
            {
                if( tim == li[i].Id)
                {
                    dem++;
                    index = i;
                }    
            }
            if (dem == 0) Console.WriteLine("Không tìm thấy thí sinh có mã vừa nhập.");
            else
            {
                Console.WriteLine(li[index]);
               
            }
        }

        
    }
}
