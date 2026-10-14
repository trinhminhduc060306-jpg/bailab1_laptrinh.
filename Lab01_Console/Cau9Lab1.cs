using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau9Lab1
    {
        public void Cau9(string[] arg)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int n = int.Parse(Console.ReadLine());
            int donvi = n / 10;
            int chuc = n % 10;
            switch(donvi)
            {
                case 1:
                    Console.Write("Mười ");
                    break;
                case 2:
                    Console.Write("Hai mươi ");
                    break;
                case 3:
                    Console.Write("Ba mươi ");
                    break;
                case 4:
                    Console.Write("Bốn mươi ");
                    break;
                case 5:
                    Console.Write("Năm mươi ");
                    break;
                case 6:
                    Console.Write("Sáu mươi ");
                    break;
                case 7:
                    Console.Write("Bảy mươi ");
                    break;
                case 8:
                    Console.Write("Tám mươi ");
                    break;
                case 9:
                    Console.Write("Chín mươi ");
                    break;
            }
            switch(chuc)
            {
                case 1:
                    Console.Write("một");
                    break;
                case 2:
                    Console.Write("hai");
                    break;
                case 3:
                    Console.Write("ba");
                    break;
                case 4:
                    Console.Write("bốn");
                    break;
                case 5:
                    Console.Write("năm");
                    break;
                case 6:
                    Console.Write("sáu");
                    break;
                case 7:
                    Console.Write("bảy");
                    break;
                case 8:
                    Console.Write("tám");
                    break;
                case 9:
                    Console.Write("chín");
                    break;
            }
        }

    }
}
