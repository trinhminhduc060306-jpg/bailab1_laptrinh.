namespace Lab01_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int chon;
            do
            {
                Console.WriteLine("\n========== MENU CÁC BÀI LAB 01 ==========");
                Console.WriteLine("1. Câu 1");
                Console.WriteLine("2. Câu 2");
                Console.WriteLine("3. Câu 3");
                Console.WriteLine("4. Câu 4");
                Console.WriteLine("5. Câu 5");
                Console.WriteLine("6. Câu 6");
                Console.WriteLine("7. Câu 7");
                Console.WriteLine("8. Câu 8");
                Console.WriteLine("9. Câu 9");
                Console.WriteLine("10. Câu 10");
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
                        Cau1Lab1 c1 = new Cau1Lab1();
                        c1.Cau1(args);
                        break;
                    case 2:
                        Cau2Lab1 c2 = new Cau2Lab1();
                        c2.Cau2(args);
                        break;
                    case 3:
                        Cau3Lab1 c3 = new Cau3Lab1();
                        c3.Cau3(args);
                        break;
                    case 4:
                        Cau4Lab1 c4 = new Cau4Lab1();
                        c4.Cau4(args);
                        break;
                    case 5:
                        Cau5Lab1 c5 = new Cau5Lab1();
                        c5.Cau5(args);
                        break;
                    case 6:
                        Cau6Lab1 c6 = new Cau6Lab1();
                        c6.Cau6(args);
                        break;
                    case 7:
                        Cau7Lab1 c7 = new Cau7Lab1();
                        c7.Cau7(args);
                        break;
                    case 8:
                        Cau8lab1 c8 = new Cau8lab1();
                        c8.Cau8(args);
                        break;
                    case 9:
                        Cau9Lab1 c9 = new Cau9Lab1();
                        c9.Cau9(args);
                        break;
                    case 10:
                        Cau10Lab1 c10 = new Cau10Lab1();
                        c10.Cau10(args);
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
