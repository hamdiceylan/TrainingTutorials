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
            Console.WriteLine("Adýnýzý Giriniz");
            isim = Console.ReadLine();
            uzunluk = isim.Length;
            Console.WriteLine("Karakter Sayýsý " + uzunluk.ToString());
            Console.ReadKey();

            Console.WriteLine("Metni Giriniz: ");
            string metin = Console.ReadLine();

            Console.WriteLine("Karakteri Giriniz: ");
            string karakter = Console.ReadLine();

            int sira = metin.IndexOf(karakter);

            Console.WriteLine(" Sýra : " + sira.ToString());

            Console.ReadKey();

            string txt1 = "Baþaran Akademisi";
            string txt2 = " Biliþim";
            string sonuc = txt1.Insert(7, "Biliþim");
            Console.WriteLine(sonuc);


            Console.WriteLine("Metin Giriniz: ");
            string metin = Console.ReadLine();

            //ilk durum
            metin = metin.Replace("þ", "s").Replace("ý", "i");

            //ikinci durum
            metin = metin.Replace("þ", "s");
            metin.Replace("ý", "i");



            Console.WriteLine(metin);

            Console.WriteLine("Metin Giriniz: ");
            string metin = Console.ReadLine();

            if ((metin.IndexOf("þ") == -1) && (metin.IndexOf("ý") == -1))
            {
                Console.WriteLine("Metinde þ  ve ý yok ");
            }
            else
            {
                Console.WriteLine("Metinde þ  ve ý var yeni metin aþaðýda ");
                metin = metin.Replace("þ", "s").Replace("ý", "i");
                Console.WriteLine(metin);
            }
            Console.ReadKey();

        }
    }
}
