using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Notu Giriniz");
                int not = Convert.ToInt32(Console.ReadLine());
                if (not > 100)
                {
                    Console.WriteLine("100 den kucuk giriniz.");
                }
                else if (not < 0)
                {
                    Console.WriteLine("0 dan buyuk giriniz");
                }
                else if (not < 50)
                {
                    Console.WriteLine("Kaldýnýz");
                }
                else
                {
                    Console.WriteLine("Geçtiniz");
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er.Message);

            }
            Console.ReadKey();

            Console.WriteLine("1-7 arasý rakam giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salý");
                    break;
                case 3:
                    Console.WriteLine("Çarþamba");
                    break;
                case 4:
                    Console.WriteLine("Perþembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
            }


        }

    }
}
