using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0102Dersler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ders1
            #region yazdıma komutları

            ////Console.WriteLine("Merhaba Dünya");
            ////Console.Write("selam");

            //Console.WriteLine("*** Yemek Kategorileri ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*** Yemek Kategorileri ***");
            #endregion

            #region Değişkenler
            ////string
            ////Değişken_türü değişken_adı;

            ////string name;
            ////name = "Tuğba";
            ////Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";
            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine();
            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 400 30 20";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";
            //Console.WriteLine("*** Rezervasyon Kartı ***");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");
            #endregion

            #region int değişkenler
            ////int
            ////int number = 24;
            ////Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;
            //Console.WriteLine("**** Restoran Menü Fiyatı***");
            //Console.WriteLine();
            //Console.WriteLine("----Hamburger: " + hamburgerPrice +" TL");
            //Console.WriteLine("----Pizza: " + pizzaPrice + " TL");
            //Console.WriteLine("----Kola: " + cokePrice + " TL");
            //Console.WriteLine("----Limonata: " + lemonadePrice + " TL");
            //Console.WriteLine("----Kızartma: " + friesPrice + " TL");
            //Console.WriteLine("----Su: " + waterPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("**** Restoran Menü Fiyatı***");

            //Console.WriteLine();
            //int hamburgerCount;
            //int cokeCount;
            //int waterCount;
            //int friesCount;
            //int pizzaCount;
            //int lemonadeCount;

            //int totalHamburgerPrice = 0;
            //int totalCokerPrice = 0;
            //int totalWaterPrice = 0;
            //int totalFriesPrice = 0;
            //int totalPizzaPrice = 0;
            //int totalLemonadePrice = 0;

            //hamburgerCount = 3;
            //cokeCount= 3;
            //waterCount= 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;
            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalCokerPrice = cokeCount * cokePrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //totalWaterPrice = waterCount * waterPrice;

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            //Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            //Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            //Console.WriteLine("Kola Tutarı: " + totalCokerPrice + " TL");
            //Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            //Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            //Console.WriteLine();
            //int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokerPrice + totalLemonadePrice + totalWaterPrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion

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

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--- Elma Birim Fiyatı: "  + String.Format("{0:C}", applePrice));
            Console.WriteLine("--- Portakal Birim Fiyatı:" + String.Format("{0:C}", orangePrice));
            Console.WriteLine("--- Çilek Birim Fiyatı:" + String.Format("{0:C}", strawberryPrice));
            Console.WriteLine("--- Patates Birim Fiyatı:" + String.Format("{0:C}", potatoPrice));
            Console.WriteLine("--- Domates Birim Fiyatı:" + String.Format("{0:C}", tomatoPrice));

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;
            Console.WriteLine();
            Console.WriteLine("Alınan Ürün: Elma -  " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar:" + appleTotalPrice);
            Console.WriteLine("Alınan Ürün: Portakal -  " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar:" + orangeTotalPrice);
            Console.WriteLine("Alınan Ürün: Çilek -  " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar:" + strawberryTotalPrice);
            Console.WriteLine("Alınan Ürün: Patates -  " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar:" + potatoTotalPrice);
            Console.WriteLine("Alınan Ürün: Domates -  " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine();
            Console.WriteLine("Alışverişin Toplam Tutarı: " + shoppingTotalPrice + "TL");

            #endregion
            #region Char Değişkenler
            ////ABCDEFGH
            ////DEF...
            ////TOPLANTI SAAT 20:00'DE
            ////" ' 
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region klavyeden veri girişleri string değişkenler
            //Console.WriteLine(" *** CSharp Hava Yolları *** ");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------");
            //Console.WriteLine("Yolcu TC Kimlik No: "+passengerIdentityNumber+" - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname +" "+passengerDistrict+" / "+passengerCity+" "+passengerAge);

            #endregion

            #region Klavyeden tam sayı girişleri ve dönüşümler
            ////ABC12D
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz: " + totalPrice);
            #endregion

            #region klavyeden ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);
            #endregion


            #region kalvyeden karakter girişleri
            char gender;
            Console.Write("Lütefen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("seçtiğiniz cinsiyet: " + gender);
            #endregion


            Console.ReadLine();
            #endregion
        }
    }
}
