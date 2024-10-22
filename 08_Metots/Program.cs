using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metots
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar
            //// sonunda () vardır 
            //// sol tarafta mor renkte küp alır
            //// 2'ye ayrılır geri değer döndürmeyen metotlar 
            //// customer --> listele, ekle, sil, güncele  -->bunları gerçekleştirirken buranın içerisinde her bir adımdan sonra bir şeyi tekrar çağırmak gerekir 
            //// mesela ekleme yaptınız listelemeyi tekrar çağırıp görebilirsiniz 
            //// void olarak tanımlanırlar 
            //void CustomerList()
            //{
            //    Console.WriteLine("tuğba");
            //    Console.WriteLine("ç");
            //    Console.WriteLine("e");
            //    //bu haliyle ekrana yazdırmaz çünkü çağırmadık
            //}
            //CustomerList(); // bunun üzerinde geldiğimiz de kilit sembolü var bu da onun private bir metot olduğunu gösterir
            ////video da 3 kere çağırdı hepsini yazması için 

            //void Sum()
            //{
            //    int x = 1, y = 3;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum(); 



            #endregion

            #region geriye değer döndürmeyen metotlar 
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("tuğba");


            #endregion

            #region geriye değer döndürmeyen int parametreli metotlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1, 2, 3);
            #endregion

            #region geriye değer döndüren metotlar 
            ////void olarak değilde değişken türü sınıf gibi tanımlanıyor
            //// dönüş değerleri return 
            //string customerName()
            //{
            //    return "Tuğba";

            //}
            //customerName();

            //string srudentCard()
            //{
            //    string name = "tuğba";
            //    string name2 = "erdğmuş";
            //    //Console.WriteLine(return); //böyle olmaz 
            //    return name + " " + name2;
            //}Console.WriteLine(srudentCard());

            #endregion

            #region geriye değer döndüren string parametreli metotlar 

            //string countryCard(string name, string capital, string flagColor)
            //{

            //    string cardInfo = name + " " + capital + " " + flagColor;
            //    return cardInfo;

            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Ülke başkentini giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Ülke bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));
            //Console.WriteLine(countryCard("Türkiye","Ankara","Kırmızı Beyaz"));

            #endregion

            #region geriye değer döndüren int parametreli metotlar 

            //int Sum(int n1, int n2)
            //{
            //    int result = n1 + n2;
            //    return result;
            //}
            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(120, 78));

            #endregion

            #region örnek uygulama
            //string examResult(string student, int s1, int s2, int s3)
            //{
            //    int result = (s1 + s2 + s3) / 3;
            //    if(result >= 50) { return student + " isimli öğreci geçti " + "ortalama: " + result; }
            //    else { return student + " isimli öğreci kaldı " + "ortalama: " + result; }

            //}
            //Console.WriteLine(examResult("ttt", 10, 45, 78));
            #endregion

            Console.ReadLine();
        }
    }
}
