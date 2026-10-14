using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau3Lab1
    {
        public void Cau3(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập điểm : ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 10)
            {
                Console.WriteLine("Điểm không hợp lệ!");
                return;
            }
            else if(n >= 9)
            {
                Console.WriteLine("Học lực: Xuất sắc");
            }
            else if (n >= 8)
            {
                Console.WriteLine("Học lực: Giỏi");
            }
            else if (n >= 7)
            {
                Console.WriteLine("Học lực: Khá");
            }
            else if (n >= 5)
            {
                Console.WriteLine("Học lực: Trung bình");
            }
            else
            {
                Console.WriteLine("Học lực: Yếu");
            }
        }
    }
}
