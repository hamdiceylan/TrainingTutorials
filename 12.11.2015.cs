using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 x 2 tipinden matris giriniz");
            // 0,0 0,1 1,0 1,1 
            int[,] matrisA = new int[2, 2];
            int[,] matrisB = new int[2, 2];
            int[,] matrisSonuc = new int[2, 2];

            #region matrisA degerleri al�nd�
            for (int satir = 0; satir < 2; satir++)
            {
                for (int sutun = 0; sutun < 2; sutun++)
                {
                    //Console.WriteLine(satir.ToString() + "Sat�rday�z" + sutun.ToString() + "s�tunday�z" );
                    Console.WriteLine("(" + satir.ToString() + "," + sutun.ToString() + ") konumundaki say�y� giriniz");
                    matrisA[satir, sutun] = Convert.ToInt32(Console.ReadLine());
                }
            }
            #endregion
            #region matrisA test ama�l� olarak ekrana yazd�r�ld�
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine("Girdi�iniz dizide (" + i.ToString() + "," + j.ToString() + ") konumundaki de�er: " + matrisA[i, j]);
            //    }
            //}
            #endregion
            #region matrisA formatl� olarak ekrana yazd�r�ld�
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(matrisA[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region MatrisB degerleri al�nd�
            for (int satir = 0; satir < 2; satir++)
            {
                for (int sutun = 0; sutun < 2; sutun++)
                {
                    //Console.WriteLine(satir.ToString() + "Sat�rday�z" + sutun.ToString() + "s�tunday�z" );
                    Console.WriteLine("(" + satir.ToString() + "," + sutun.ToString() + ") konumundaki say�y� giriniz");
                    matrisB[satir, sutun] = Convert.ToInt32(Console.ReadLine());
                }
            }
            #endregion
            #region Matrisler topland�
            for (int satir = 0; satir < 2; satir++)
            {
                for (int sutun = 0; sutun < 2; sutun++)
                {
                    matrisSonuc[satir, sutun] = matrisA[satir, sutun] + matrisB[satir, sutun];
                }
            }
            #endregion
            #region matrisSonuc formatl� olarak ekrana yazd�r�ld�
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(matrisSonuc[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region matrislerin hepsinin formatl� olarak ekrana yazd�r�ld�

            for (int satir = 0; satir < 2; satir++)
            {
                for (int sutun = 0; sutun < 1; sutun++)
                {
                    Console.Write(matrisA[satir, sutun] + " ");
                    //hamdiceylan@gmail.com
                    if (sutun == 0)
                    {
                        Console.Write(matrisA[satir, sutun+1] + " ");
                    }
                    else
                    {
                        Console.Write(matrisA[satir, 1] + " ");
                    }
                    Console.Write(matrisB[satir, sutun] + " ");
                    if (sutun == 0)
                    {
                        Console.Write(matrisB[satir, sutun + 1] + " ");
                    }
                    else
                    {
                        Console.Write(matrisB[satir, 1] + " ");
                    }
                    Console.Write(matrisSonuc[satir, sutun] + " ");
                    if (sutun == 0)
                    {
                        Console.Write(matrisSonuc[satir, sutun + 1] + " ");
                    }
                    else
                    {
                        Console.Write(matrisSonuc[satir, 1] + " ");
                    }
                }
                Console.WriteLine();
            }
            //Buras� ilkel y�ntem Cemallettin g�rs�n diye b�rak�yorum, s�n�fa selamlar
            //for (int sutun = 0; sutun < 1; sutun++)
            //{
            //    Console.Write(matrisA[1, sutun] + " ");
            //    Console.Write(matrisA[1, 1] + " ");
            //    Console.Write(matrisB[1, sutun] + " ");
            //    Console.Write(matrisB[1, 1] + " ");
            //    Console.Write(matrisSonuc[1, sutun] + " ");
            //    Console.Write(matrisSonuc[1, 1] + " ");
            //}
            #endregion
            //1 2  4 3  5 5
            //3 4  2 1  5 5

            Console.ReadKey();
        }
    }
}
