using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü
            //Döngüler 1 2 3 4 5 6
            //3+3=6+4=10+5=15+6=21
            //For(x;y;z)
            //x: başlangıç değeri
            //y: bitiş değeri
            //z: artış değeri

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütden ekrana yazılamsını istediğiniz adedi giriniz: ");
            //int finishValue=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For döngüsü ile karar yapıları
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //int totalValue = 0;
            //for(int i = 1; i < 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for(int i = 1; i <=50; i++)
            //{
            //    if(i%7==0)
            //        count++;
            //}
            //Console.WriteLine(count);

            #endregion

            #region bakteri örneği
            ////1-2-4-8-15...
            //int bacterium = 1;
            //for(int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda: " + bacterium);
            //}
            #endregion

            #region while döngüsü
            /* şart sağladığı müddetçe anlamı taşımaktadırsyntax olarak fordan farklı olarak 
             * arttırma işlemi işlemlerin olduğu yerde yapılır 
             * */

            //while(şart)
            //{
            //işlemler
            //}
            //while döngüsü aslında burada şunu sunuyor bize şart işlem sağlandığı müddetçe anlamı taşıyor 

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1, sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);

            #endregion


            #region örnek sınav sorusu
            ////klavyeden girilen üç basamaklı sayının basamakları toplamını bulan döngü 
            //Console.Write("sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;
            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //Console.WriteLine(ones + " - " + tens + " - " + hundreds);
            //sum = ones + tens + hundreds;
            //Console.WriteLine(sum);

            #endregion


            //Ders 5
            #region Alt alta 10 tane yıldız oluşturma
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion
            #region yan yana 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(" * ");
            //}
            #endregion

            #region dik üçgen
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters dik üçgen
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik ve ters dik üçgen uygulaması
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for(int k = 4; k >= 1; k--)
            //{
            //    for (int m= 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region baklava dilimi 
            ////üst kısım
            //int n = 5; //satır sayısını ifade  ediyor
            //for(int i=1; i<=n; i++)
            //{
            //    for(int j=n-1;j>0; j--)
            //    {
            //        Console.Write(" "); //burada sol taraftan boşluk bırakır
            //    }
            //    for(int k = 1; k <= 2 * i - 1; k++) //yıldız sayısını ifade ediyor
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////alt kısım
            //for (int i = n-1; i >=1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" "); //burada sol taraftan boşluk bırakır
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region piramit
            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
