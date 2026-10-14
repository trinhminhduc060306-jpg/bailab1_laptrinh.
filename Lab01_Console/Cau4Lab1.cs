using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau4Lab1
    {
        public void Cau4(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int chon;
            do
            {
                Console.WriteLine("\n========== MENU ==========");
                Console.WriteLine("1. Tính tổng 1..n");
                Console.WriteLine("2. Bảng cửu chương");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Nhập không hợp lệ!");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhập n = ");
                        if (int.TryParse(Console.ReadLine(), out int n))
                        {
                            int tong = 0;
                            for (int i = 1; i <= n; i++)
                                tong += i;
                            Console.WriteLine($"Tổng = {tong}");
                        }
                        else
                        {
                            Console.WriteLine("Nhập không hợp lệ!");
                        }
                        break;

                    case 2:
                        Console.Write("Nhập số cần in bảng cửu chương: ");
                        if (int.TryParse(Console.ReadLine(), out int n2))
                        {
                            for (int i = 1; i <= 10; i++)
                                Console.WriteLine($"{n2} x {i} = {n2 * i}");
                        }
                        else
                        {
                            Console.WriteLine("Nhập không hợp lệ!");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Tạm biệt!");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (chon != 0);
        }
    }
}
