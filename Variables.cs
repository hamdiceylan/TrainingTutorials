using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Variables
    {
        int sayi = 5;
        int x, y = 8, z; //Aynı türdeki değişkenler aynı anda tek seferde tanımlanabilir.
        bool aktif = true;
        float f = 5.4f; // Değerin sonuna yer alan f harfi değişkenin float türünde olduğunu ifade eder.
        double d = 3.2;
        byte b = 230;
        long l = 123456789;
        short s = -312;
        decimal dec = -5.26m; //Değerin sonuna m harfi ekleyerek değişkenin decimal türünde olduğunu belirtiyoruz.
        char ch = 'c';  //Char tipinde ki değişkenler tek tırnak içerisine yazılır.
        string deger = "merhaba";
    }
}
