using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_Console_
{
    internal class Cau5Lab1
    {
        public void Cau5(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine($"a / b = {(double)(a / b)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu phải là số nguyên.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Không thể chia cho 0.");
            }
            finally
            {
                Console.WriteLine("Kết thúc phép tính.");
            }
        }
    }
}
