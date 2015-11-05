using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaça kadar toplayalym");
            string toplanacakSayiString = Console.ReadLine();
            int toplanacakSayi = Convert.ToInt32(toplanacakSayiString);
            //int a = Convert.ToInt32(Console.ReadLine()); 
            int toplam = 0;
            //hamdiceylan@gmail.com 
            for (int i = 0; i < toplanacakSayi; i++)
            {
                if (i % 2 == 0)
                {
                    toplam = toplam + i;
                }
            }
            Console.WriteLine(toplam);
            Console.ReadKey();
            int sayac = 5;
            while (sayac > 0)
            {
                Console.WriteLine("Sayý Büyük");
                sayac--;
            }

            int sayac = 5;
            do
            {
                Console.WriteLine("Döngüdeyim");
                sayac--;
            } while (sayac > 0);

            Console.WriteLine("Kaça kadar toplayalým");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            while (sayi > 0)
            {
                if (sayi % 2 == 0)
                {
                    toplam = toplam + sayi;
                }
                sayi--;
            }
            Console.WriteLine(toplam);

            for (int a = 0; a < 3; a++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        Console.WriteLine("i:" + i.ToString() + " a:" + a.ToString()
                            + " k:" + k.ToString());

                    }
                }
            }
            for (int k = 1; k < 11; k++)
            {
                for (int i = 1; i < 11; i++)
                {
                    int bas = k;
                    Console.WriteLine(bas.ToString() + "x" + i.ToString() + "=" + (bas * i).ToString());
                }
            }


            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if ((i * j).ToString().Length == 1)
                    {
                        Console.Write(j.ToString() + "x" + i.ToString() + ":" + (i * j).ToString() + "   ");
                    }
                    else
                    {
                        Console.Write(j.ToString() + "x" + i.ToString() + ":" + (i * j).ToString() + "  ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
