using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar

            ////()
            ////Geriye değer döndürmeyen metotlar
            ////customer-->Listele,ekle,sil,güncelle
            ////Void

            //void CustomerList() 
            //{
            //    Console.WriteLine("mert tmcn");
            //    Console.WriteLine("ftm arslan");
            //    Console.WriteLine("slyman çlb");
            //    Console.WriteLine("şvn fncn");

            //}
            //CustomerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void WriteMethod(string customerName) 
            //{
            //Console.WriteLine(customerName);
            //}

            //WriteMethod("mehemt yldrm");

            //void CustomerCard(string name,string surName) 
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet","Yldz");
            //CustomerCard("ayşegül","Kaya");



            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse ylmz";
            //}
            //CustomerName();

            //string StudentCard() 
            //{
            //    string name ="ALi";
            //    string surname = "kml";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());





            #endregion

            #region Geriye değer döndüren string parametreli Metotlar

            // string CountyCard(string countryName,string capital,string flagColor) 
            // {
            //string cardInfo="Ülke: "+countryName+" - Başkent: "+capital+" "+" - Bayrak Rengi"+ flagColor;
            //     return cardInfo;
            // }

            // string x, y, z;
            // Console.Write("Lütfen Ülke Adı Giriniz: ");
            // x = Console.ReadLine();

            // Console.Write("Başkenti Giriniz: ");
            // y = Console.ReadLine();

            // Console.Write("Bayrak Rengini Giriniz: ");
            // z = Console.ReadLine();


            // Console.WriteLine(CountyCard(x,y,z));





            #endregion

            #region Geriye değer döndüren string parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //int result= number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));





            #endregion

            #region Örnek Uygulama

            string ExamResult(string student,int exam1,int exam2,int exam3) 
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student+"İsimli Öğrenci Sınavı Geçti"+ " Ortalama:"+result;
                }
                else 
                {
                    return student+"İsimli Öğrenci Başarısız Oldu"+" Ortalama: "+result;
                }
            }

            Console.WriteLine(ExamResult("İlayda", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));





            #endregion

            Console.ReadKey();
        }
    }
}
