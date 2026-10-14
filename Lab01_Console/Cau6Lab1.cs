using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau6Lab1
    {
        public void Cau6(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a, b, c;
            Console.Write("Nhập a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("{0}x^2 + {1}x + {2} = 0", a, b, c);
            Double delta = b * b - 4 * a * c;
            if (a > 0 || a < 0)
            {
                if (delta > 0)
                {
                    Double x1 = (-b + (int)Math.Sqrt(delta)) / (2 * a);
                    Double x2 = (-b - (int)Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Nghiệm của phương trình là: x1 = {0}, x2 = {1}", x1, x2);
                }
                if (delta == 0)
                {
                    Double x = -b / (2 * a);
                    Console.WriteLine("Phương trình có nghiệm kép: x = {0}", x);
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
    }
}

