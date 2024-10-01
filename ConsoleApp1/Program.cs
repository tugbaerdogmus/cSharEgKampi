using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ders1
            #endregion
            #region ders2
            #region double değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            Console.WriteLine("*** Fiyat Listesi ***");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("--- Elma Birim Fiyatı:" + applePrice + NumberFormatInfo.CurrentInfo.CurrencySymbol);
            Console.WriteLine("--- Portakal Birim Fiyatı:" + orangePrice);
            Console.WriteLine("--- Çilek Birim Fiyatı:" + strawberryPrice);
            Console.WriteLine("--- Patates Birim Fiyatı:" + potatoPrice);
            Console.WriteLine("--- Domates Birim Fiyatı:" + tomatoPrice);

                #endregion
            #endregion
        }
    }
}
