using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi = 5;
            sayi = sayi + 10;
            sayi += 10;

            sayi = sayi - 10;
            sayi -= 10;

            sayi = sayi ^ 10;
            sayi ^= 10;

            bool aktif = true;

            aktif = aktif & false;
            aktif &= false;

            aktif = aktif | false;
            aktif |= false;

            int not1, not2, not3, kendiNotum;
            float ortalama;
            Console.WriteLine("1. Not");
            not1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Not");
            not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3. Not");
            not3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kendi Notun");
            kendiNotum = Convert.ToInt32(Console.ReadLine());

            float notlarToplami = not1 + not2 + not3 + kendiNotum;
            ortalama = (notlarToplami) / 4;

            if (kendiNotum > ortalama)
            {
                Console.WriteLine("S�n�f Ortalamas� :" + ortalama.ToString() + " �grenci Ba�ar�l�");
            }
            else
            {
                Console.WriteLine("S�n�f Ortalamas� :" + ortalama.ToString() + " �grenci Ba�ar�s�z");
            }
            Console.ReadKey();
            int not;
            Console.WriteLine("�grenci Notu");
            not = Convert.ToInt32(Console.ReadLine());
            //Sadece if kullanarak 
            if (not > 70)
            {
                Console.WriteLine("�yi");
            }
            if (not > 35)
            {
                Console.WriteLine("K�t�");
            }
            //Sadece if-else kullanarak 
            if (not > 70)
            {
                Console.WriteLine("�yi");
            }
            else if ((not < 70) && (not > 35))
            {
                Console.WriteLine("Orta");
            }
            else if (not < 35)
            {
                Console.WriteLine("K�t�");
            }
            Console.ReadKey();

       
        }
    }
}
