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
            string isim;
            int uzunluk;
            Console.WriteLine("Ad�n�z� Giriniz");
            isim = Console.ReadLine();
            uzunluk = isim.Length;
            Console.WriteLine("Karakter Say�s� " + uzunluk.ToString());
            Console.ReadKey();

            Console.WriteLine("Metni Giriniz: ");
            string metin = Console.ReadLine();

            Console.WriteLine("Karakteri Giriniz: ");
            string karakter = Console.ReadLine();

            int sira = metin.IndexOf(karakter);

            Console.WriteLine(" S�ra : " + sira.ToString());

            Console.ReadKey();

            string txt1 = "Ba�aran Akademisi";
            string txt2 = " Bili�im";
            string sonuc = txt1.Insert(7, "Bili�im");
            Console.WriteLine(sonuc);


            Console.WriteLine("Metin Giriniz: ");
            string metin = Console.ReadLine();

            //ilk durum
            metin = metin.Replace("�", "s").Replace("�", "i");

            //ikinci durum
            metin = metin.Replace("�", "s");
            metin.Replace("�", "i");



            Console.WriteLine(metin);

            Console.WriteLine("Metin Giriniz: ");
            string metin = Console.ReadLine();

            if ((metin.IndexOf("�") == -1) && (metin.IndexOf("�") == -1))
            {
                Console.WriteLine("Metinde �  ve � yok ");
            }
            else
            {
                Console.WriteLine("Metinde �  ve � var yeni metin a�a��da ");
                metin = metin.Replace("�", "s").Replace("�", "i");
                Console.WriteLine(metin);
            }
            Console.ReadKey();

        }
    }
}
