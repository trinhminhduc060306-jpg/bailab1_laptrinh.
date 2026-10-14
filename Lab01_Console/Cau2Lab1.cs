using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau2Lab1
    {
        public void Cau2(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double r, h;

            Console.Write("Bán kính r = ");
            if (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            {
                Console.WriteLine("Bán kính phải lớn hơn 0!");
                return;
            }
            Console.Write("Chiều cao h = ");
            if (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
            {
                Console.WriteLine("Chiều cao phải lớn hơn 0!");
                return;
            }
            double dienTichXQ = 2 * Math.PI * r * h;
            double theTich = Math.PI * r * r * h;
            Console.WriteLine($"Sxq = {dienTichXQ:N2}; V = {theTich:N2}");
        }
    }
}
