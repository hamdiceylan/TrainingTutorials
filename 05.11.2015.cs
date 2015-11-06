using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi Sayýyý Kontrol edelim?");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int k = 2; k < sayi; k++)
            {
                bool asalMi = true;
                for (int i = 2; i < k; i++)
                {
                    if (k % i == 0)
                    {
                        asalMi = false;
                    }
                }
                if (asalMi)
                {
                    Console.WriteLine(k.ToString());
                }
            }

            Console.WriteLine("Hangi Sayýyý Kontrol edelim?");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            for (int k = 2; k < sayi; k++)
            {
                bool asalMi = true;

                for (int i = 2; i < (k/2)+1; i++)
                {
                    if (k % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                    sayac++;
                }
                if (asalMi)
                {
                    Console.WriteLine(k);
                }
            }
            Console.WriteLine(sayac.ToString() + " kadar deneme yaptým");
            Console.ReadKey();

            Console.WriteLine("Kaça Kadar Kontrol Edeceðim");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < limit; i++)
            {
                bool asalMi = true;
                for (int k = 3; k < i; k++)
                {
                    if (i % 2 == 0)
                    {
                        asalMi = false;
                    }
                }
                if (asalMi)
                {
                    Console.WriteLine(i);
                }
                asalMi = true;
            }
            Console.ReadKey();
        }
    }
}


           
