using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eni metre olarak Giriniz :");
            int en = Convert.ToInt32(Console.ReadLine());
            Console.Write("Boyu metre olarak Giriniz :");
            int boy = Convert.ToInt32(Console.ReadLine());
            int alan = en * boy;
            Console.WriteLine("Girdiğiniz dikdörtgenin alanı " + alan.ToString()  + " metrekaredir.");
            Console.ReadLine();
            int ogrenciSayisi = 5;
            ogrenciSayisi = ogrenciSayisi + 1;
            ogrenciSayisi++;

            Console.WriteLine("Ögrenci saysısı giriniz");
            int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());
            ogrenciSayisi++;
            Console.WriteLine("1 ögrenci daha katılırsa yeni mevcut" + ogrenciSayisi.ToString() + "olacaktır.");

            int kalan = 16 % 7;
            Console.WriteLine(kalan);
            Console.ReadLine();

            Console.WriteLine("Davetli saysısı giriniz");
            int davetliSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masa Kapasitesi giriniz");
            int masaKapasitesi = Convert.ToInt32(Console.ReadLine());

            int kalan = davetliSayisi % masaKapasitesi;
            int kullanilanMasaSayisi = davetliSayisi / masaKapasitesi;

            Console.WriteLine("Toplam " + kullanilanMasaSayisi.ToString()+ " masa kullanıldı ve son masada oturan kişi sayısı " + kalan.ToString());
            Console.ReadLine();
            string name = "Başaran";
            //< > => <= !=
            if (  ( (15 != 8) && (3 > 5) ) || name == "Başaran")//Koşulum
            //if ((15 != 8) || (3 > 5))//Koşulum 5 küçüktür 8
            {
                //Koşul Doğru ise çalışır
                Console.WriteLine("Doğru");
            }
            else
            {
                //Koşul Yanlış işe Çalışır
                Console.WriteLine("Yanlış");
            }
            Console.ReadLine();
        }
    }
}
