using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau7Lab1
    {
        public void Cau7(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhap so luong so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            double tongchan = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    tongchan += arr[i];
                }
            }
            Console.WriteLine($"Tong cac phan tu trong mang la: {sum}");
            Console.WriteLine($"Gia tri lon nhat trong mang la: {max}");
            Console.WriteLine($"Gia tri nho nhat trong mang la: {min}");
            Console.WriteLine($"Tong cac so chan trong mang la: {tongchan}");

        }
    }
}
