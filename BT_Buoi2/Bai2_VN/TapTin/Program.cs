using System;
using System.IO;

namespace TapTin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            StreamReader streamReader = null;
            StreamWriter streamWriter = null;
            int sum = 0;
            try
            {   // Nhap thong tin vào file
                StreamWriter sw = new StreamWriter("input.txt", false);
                    sw.WriteLine("2");
                    sw.WriteLine("2");
                    sw.WriteLine("2 4");
                    sw.WriteLine("1 7");
                    sw.Close();

                streamReader = new StreamReader("input.txt");
                int hang = Convert.ToInt32(streamReader.ReadLine());
                int cot = Convert.ToInt32(streamReader.ReadLine());

                int[,] a = new int[hang, cot];
                for (int i = 0; i < hang; i++)
                {
                    string temp = streamReader.ReadLine();
                    string[] num = temp.Split(new char[] { ' ' });
                    for (int j = 0; j < cot; j++)
                    {
                        a[i, j] = Convert.ToInt32(num[j]);
                        sum += a[i, j];
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Có lỗi: " + e.Message);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                    try
                    {
                        streamWriter = new StreamWriter("input.txt", true);
                        streamWriter.WriteLine("\nTổng các phần tử trong ma trận = " + sum);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Có lỗi: " + e.Message);
                    }
                    finally
                    {
                        if (streamWriter != null)
                            streamWriter.Close();
                    }
                }

            }

            Console.WriteLine("Chương trình chạy thành công");
            Console.ReadLine();
        }
    }
}
