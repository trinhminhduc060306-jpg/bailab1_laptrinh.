using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau10Lab1
    {
        static bool tamgiacvuongdac(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            return false;
        }
        static bool tamgiacvuongrong(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 || j == i || i == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            return false;
        }
        static bool hinhvuongrong(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            return false;
        }
        public void Cau10(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Chọn hình (1: tam giác đặc, 2: tam giác rỗng, 3: hình vuông rỗng): ");
            int choose = int.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    tamgiacvuongdac(n);
                    break;
                case 2:
                    tamgiacvuongrong(n);
                    break;
                case 3:
                    hinhvuongrong(n); 
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
            

        }
    }

}
