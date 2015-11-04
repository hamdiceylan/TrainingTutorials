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
            #region try catch ve switch
            try
            {
                Console.WriteLine("1-7 arasý rakam giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 8 && sayi > 0)
                {
                    #region Açýklama
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
                    #endregion
                }
                else
                {
                    Console.WriteLine("1-7 arasýnda bir deger giriniz");
                }
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
            }
            #endregion
            #region for
            for (int i = 0; i < 201; i++)
            {
                Console.WriteLine(i.ToString());
            }

            #endregion

            Console.WriteLine("Kaça kadar toplayalým");
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
        }
    }
}
