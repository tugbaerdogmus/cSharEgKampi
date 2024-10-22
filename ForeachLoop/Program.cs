using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü
            //foreach(1;2;3;4)
            //1. değişken türü 
            //2. değişken adı
            //3. In
            //4. liste, koleksiyon, dizi
            //c# da yer alıyor

            //string[] cities = { "ankara", "milano", "varşova", "istanbul", "budapeşte" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //listeler bir koleksiyon üyesidir. dizilere benzerler ama biraz farkı var 
            //liste oluşturma, başlangıçta tipini belirlememize de ister
            //List<int> numbers = new List<int>();
            List<int> numbers = new List<int>()

            //listeye değer atama yapılabilir
            {
                1, 2, 3, 4, 5, 6, 7
            };
            //Console.WriteLine(numbers); //bu şekildeyazdırma yapılamaz
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion


            #region Örnek Sınav Uygulaması

            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");
            string[] studentNames=new string[studentCount];
            double[] studenExamAvg=new double[studentCount];

            for(int i=0; i<studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i]=Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 3 sınav notu girişi
                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz
                }
                Console.WriteLine();
                studenExamAvg[i] = totalExamResult / 3;
            }

            //öğrencinin ortalamasını
            for(int i=0; i<studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studenExamAvg[i]}");
                
                //geçip kalma durumları
                if (studenExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrencinci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrencinci dersten kaldı");
                }
                Console.WriteLine("----------------------");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
