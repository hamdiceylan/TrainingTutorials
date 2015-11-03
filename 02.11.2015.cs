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
                    Console.WriteLine("Kald�n�z");
                }
                else
                {
                    Console.WriteLine("Ge�tiniz");
                }
            }
            catch (Exception er)
            {

                Console.WriteLine(er.Message);

            }
            Console.ReadKey();

            Console.WriteLine("1-7 aras� rakam giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Sal�");
                    break;
                case 3:
                    Console.WriteLine("�ar�amba");
                    break;
                case 4:
                    Console.WriteLine("Per�embe");
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
