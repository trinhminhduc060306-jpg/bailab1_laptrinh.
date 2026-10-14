using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau8lab1
    {
        static bool LaSoNguyenTo(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i <= n; i++)
            {
                if(i * i < n)
                {
                    if (n % i == 0)
                        return false;
                }
                   
            }

            return true;
        }
        public void Cau8(string[] arg)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số nguyên n: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 2)
            {
                Console.WriteLine($"\nCác số nguyên tố nhỏ hơn {n}:");
                for (int i = 2; i < n; i++)
                {
                    if (LaSoNguyenTo(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Nhập lại n >= 2");
            }
        }
    }
}
