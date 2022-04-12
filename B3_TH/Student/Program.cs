using System;
using System.IO;

namespace Student
{
    class Program
    {

        struct Student
        {
            public int id;
            public string ten;
            public string gioiTinh;
            public int tuoi;
            public double diemToan;
            public double diemLy;
            public double diemHoa;
  /*          public double diemTB;
            public string hocluc;*/

            public void nhap()
            {
                
                Console.Write("Nhap ten hoc sinh: ");
                ten = Console.ReadLine();
                Console.Write("Nhap gioi tinh: ");
                gioiTinh = Console.ReadLine();
                Console.Write("Nhap tuoi hoc sinh: ");
                tuoi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap diem toan hoc sinh: ");
                diemToan = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem ly hoc sinh: ");
                diemLy = double.Parse(Console.ReadLine());
                Console.Write("Nhap diem hoa hoc sinh: ");
                diemHoa = double.Parse(Console.ReadLine());
            }

            public double diemTB()
            {
                return (diemToan + diemLy + diemHoa) / 3;
            }
            public string xepLoai(double diem)
            {
                if (diem >= 8)
                {
                    return "Gioi";
                } else if (diem < 8 || diem >= 6.5)
                {
                    return "Kha";
                }
                else if (diem < 6.5 || diem >= 5)
                {
                    return "Trung Binh";
                }
                else 
                {
                    return "Yeu";
                }
            }
            
            public string ghi()
            {
                return "Sinh vien[" + this.id + "]:  " + this.ten + "  " + this.gioiTinh + "  " + this.diemToan + "  " + this.diemLy
                + "  " + this.diemHoa + "  " + this.diemTB() + "  " + this.xepLoai(this.diemTB());
            }
            
        }
         static void XuatThongTinSinhVien(Student[] sv, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien[" + sv[i].id + "]:  " + sv[i].ten + "  " + sv[i].gioiTinh + "  " + sv[i].diemToan + "  " + sv[i].diemLy
                + "  " + sv[i].diemHoa + "  " + sv[i].diemTB() + "  " + sv[i].xepLoai(sv[i].diemTB()));
            }

        }
        static void CapNhat(ref Student[] sv, int id, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (sv[i].id == id)
                {
                    sv[i].nhap();
                    sv[i].diemTB();
                    sv[i].xepLoai(sv[i].diemTB());
                }
                else
                {
                    Console.WriteLine("Khong ton tai Id");
                }
            }

        }

        static void XoaPhanTu(ref Student[] SV, ref int n, int position)
        {
            // Mang rong, khong the xoa.
            if (n <= 0)
            {
                return;
            }
            // Neu position <= 0 => Xoa dau
            if (position < 0)
            {
                position = 0;
            }
            // Neu position >= n => Xoa cuoi
            else if (position >= n)
            {
                position = n - 1;
            }
            // Dich chuyen mang
            for (int i = position; i < n - 1; i++)
            {
                SV[i] = SV[i + 1];
            }
            // Giam so luong phan tu sau khi xoa.
            --n;
        }

        static void searchName(Student[] sv, int n, String s)
        {
            for (int i = 0; i < n; i++)
            {
                if (String.Compare(sv[i].ten, s, true) == 0)
                {
                    Console.WriteLine("Sinh vien[" + sv[i].id + "]:  " + sv[i].ten + "  " + sv[i].gioiTinh + "  " + sv[i].diemToan + "  " + sv[i].diemHoa
                + "  " + sv[i].diemHoa + "  " + sv[i].diemTB() + "  " + sv[i].xepLoai(sv[i].diemTB()));
                }
            }
        }
        static void swapStudent(Student a, Student b)
        {
            Student temp = a;
            a = b;
            b = temp;
        }
        static void sapXepDanhSachSinhVien(ref Student[] sv, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (sv[i].diemTB() > sv[j].diemTB())
                    {
                        swapStudent(sv[i], sv[j]);
                    }
                }
            }
        }
        static void sapXepDanhSachSinhVienTheoTen(ref Student[] sv, int n)
        {
            for (int i = 0; i < n -1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((sv[i].diemTB()).Equals(sv[j].diemTB()))
                    {
                        swapStudent(sv[i], sv[j]);
                    }
                }
            }
        }
        static void ghiFile(ref Student[] sv, int n)
        {
            string fileName = "student.txt";
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(fileName);
                for (int i = 0; i < n; i++)
                {
                    Student x = sv[i];
                    Console.WriteLine(x.ghi());
                    streamWriter.Write(x.ghi());
                }
                Console.WriteLine("Writing file complete.");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Can not openfile " + fileName);
                Console.WriteLine("Error: " + e.ToString());
                throw;
            } finally
            {
                if (streamWriter != null) streamWriter.Close();
            }
            Console.ReadLine();
        }
        
        
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("--------------------MENU CHUC NANG--------------------");
                int chon;
                int count = 0;
                Student[] sv = new Student[99];
                do
                {
                    Console.Write("1\tNhap sinh vien\n");                   
                    Console.Write("2\tCap nhat sinh vien theo ID\n");
                    Console.Write("3\tXoa sinh vien theo ID\n");
                    Console.Write("4\tTim kiem sinh vien theo ten :\n");
                    Console.Write("5\tSap xep sinh vien theo diem trung binh :\n");
                    Console.Write("6\tSap xep sinh vien theo ten :\n");
                    Console.Write("7\tHien thi danh sach sinh vien\n");
                    Console.Write("8\tGhi danh sach sinh vien vao file\n");
                    Console.Write("9\tthoat\n");

                    Console.WriteLine();
                    chon = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (chon)
                    {
                        case 1:
                            sv[count] = new Student();
                            sv[count].id = count;
                            sv[count].nhap();
                            count++;
                            break;
                       case 2:
                            Console.WriteLine("Nhap Id cua sinh vien muon sua : ");
                            int id = int.Parse(Console.ReadLine());
                            CapNhat(ref sv, id, count);
                            break;
                       case 3:
                            Console.WriteLine("Nhap ma sinh vien muon xoa : ");
                            int maSV = int.Parse(Console.ReadLine());
                            XoaPhanTu(ref sv, ref count, maSV);
                            break;
                        case 4:
                            Console.WriteLine("Nhap ten cua sinh vien muon tim :");
                            String name = Console.ReadLine();
                            searchName(sv, count, name);
                            break;
                        case 5:
                            sapXepDanhSachSinhVien(ref sv, count);
                            Console.WriteLine("Da sap xep xong, in lai de xem ket qua");
                            break;
                        case 6:
                            sapXepDanhSachSinhVienTheoTen(ref sv, count);
                            Console.WriteLine("Da sap xep xong, in lai de xem ket qua");
                            break;
                        case 7:
                            XuatThongTinSinhVien(sv, count);
                            break;
                        case 8:
                            ghiFile(ref sv, count);
                            break;
                        default:
                            Console.WriteLine("Lua chon sai roi");
                            break;
                    }
                } while (true);
            }
            catch (Exception e)
            {

                Console.WriteLine("Lỗi: " + e.Message);
            }

        }
    }
}
