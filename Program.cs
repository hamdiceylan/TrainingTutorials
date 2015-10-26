using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("İlk Sayıyı Giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Giriniz :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayıların toplamı : "+ (sayi1+sayi2).ToString());
            Console.ReadLine();
        }
    }
}
