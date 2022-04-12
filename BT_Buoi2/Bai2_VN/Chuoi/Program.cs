using System;

namespace Chuoi
{
    class Program
    {
        //a.Cho phép người dùng nhập vào một chuỗi, hiển thị mỗi ký tự trong chuỗi
        //trên 1 dòng.

        //b.Cho phép người dùng nhập vào một chuỗi gồm các ký tự và khoảng trắng, hiển thị
        //mỗi từ trên 1 dòng(bỏ qua các khoảng trắng thừa).


        //c.Cho phép người dùng nhập vào một chuỗi, hiển thị số lần xuất hiện của mỗi
        //ký tự trong chuỗi.
        static int dem(char c, string str)  // ham dem so lan xh cua 1 ky tu trong chuoi
        {
            int answer = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    answer++;
                }
            }
            return answer;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8; 
            string str;
            Console.Write("Nhap chuoi: ");
            str = Console.ReadLine();
            Console.WriteLine("Chuoi bạn vua nhap la: "+ str);

            //CAU A
            //for( int i=0; i<str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //CAU B
            //str = str.Trim(); // xóa dấu cách thừa ở đầu và ở cuối xâu
            //while( str.IndexOf("  ") != -1 )  // Tìm ra vị trí có 2 dấu cách liền nhau
            //{
            //    str = str.Remove(str.IndexOf("  "), 1);

            //}
            //// Kiểm tra nếu có 2 dấu cách liền nhau thì xóa 1 dấu đi bằng câu lệnh remove
            //Console.WriteLine("Chuoi sau khi xoa cach thua la: " + str);
            //// Phan tach dòng theo yeu cau
            //Console.WriteLine(" yeu cau cau b la: \n");
            //while (str.IndexOf(" ") != -1)
            //    {
            //        Console.WriteLine(str.Substring(0,str.IndexOf(" "))); // căt chuỗi từ vị trí x đến vị trí y
            //        str = str.Substring(str.IndexOf(" ")+1); //cắt chuỗi từ vị trí đến hết
            //    }
            //string chuoicuoi = str.Substring(str.LastIndexOf(" ")+1);
            //Console.WriteLine(chuoicuoi);

            //CAU C: số lần xh của mỗi ký tự trong chuối , co phan biet hoa thuong

            // xoa cac ky tu trung lap nhau
            string str2 = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
               
                //nếu ký tự đã có trong chuỗi kết quả thì bỏ qua
                //ngược lại nếu chưa có thì thêm vào cuỗi chuỗi
                if (!str2.Contains(str[i]))
                {
                    str2 += str[i];
                }

            }
            Console.WriteLine("So ki tu của chuoi la: ");
            for ( int i=0; i<str2.Length; i++)
            {   
                char c;
                c = str2[i];
                {
                    int demphu = dem(c, str);
                    Console.WriteLine(" Ký tự " + c + " : " + demphu + " lan");
                }
            }    
        }
    }
}
