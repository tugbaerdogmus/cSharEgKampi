using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // DeğişkenTürü [] DiziAdı=new DegiskenTuru[Eleman Sayısı]
            //string[] colors=new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Sarı";
            //colors[3] = "Turuncu";
            //Console.WriteLine(colors[2]);

            //string[] cities = { "Roma", "Prag", "Kahire", "Üsküp", "Fas" };
            //Console.WriteLine(cities[0]);

            #endregion

            #region Dizilerle beraber tüm elemanları listeleme
            //string[] colors = { "Kırmızı", "Mavi", "Sarı", "Turuncu", "Yeşil", "Beyaz" };
            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] number = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0) { Console.WriteLine(number[i]); }
            //}
            //// char değişkenler tanımlanırken dizilerde ' ' kullanılır
            ///

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber=myArray[0];
            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber= myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion
            #region Dizi Metotlar
            //length: dizi uzunluğu
            //Array.Sort: sıralama yapar -küçükten büyüğe
            //Array.Reverse: tersten sıralar - yazılıdığı şeklin tersini yani diziyi ters çevirir 
            //indexof: dizi içerisinde aranan elemanın sırasını verir

            #endregion

            #region Kullanıcıdan değer alma
            // $ ifadesi string bir ifadeyi yazarken içerisinde parametresel ifadeler kullanmaya yarar
            string[] cities = new string[5];
            for(int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. şehri giriniz ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("--------------");
            for(int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
            #endregion

            Console.Read();
        }
    }
}
