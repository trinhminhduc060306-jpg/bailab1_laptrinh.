using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau1Lab1
    {
        public void Cau1(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: ");
            int namSinh = int.Parse(Console.ReadLine());
            int tuoi = DateTime.Now.Year - namSinh;
            Console.WriteLine($"Xin chào {hoTen}, sinh năm {namSinh} và hiện tại {tuoi} tuổi.");
        }
    }
}
