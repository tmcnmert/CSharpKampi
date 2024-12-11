using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1: Değişken türü
            //2: Değişken adı
            //3: In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities) 
            //{
            //Console.WriteLine(city);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 205, 6578, 10394 };

            //foreach (int i in numbers) 
            //{
            //Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 205, 6578, 10394 };

            //foreach (int number in numbers) 
            //{
            //if (number % 2 == 0) 
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 205, 6578, 10394,41};
            //int total = 0;

            //foreach (int i in numbers) 
            //{
            //total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{ 
            //1,2,3,4,5,8
            //};
            //foreach (int number in numbers) 
            //{
            //Console.WriteLine(number);
            //}

            //string word = "Merahaba";

            //foreach (char i in word) 
            //{
            //Console.WriteLine(i);
            //}




            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("*****  C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //öğrenci isimlerini ve not ortalamalarını sakalyacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i = 0; i < studentCount; i++) 
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0;j<3;j++) 
                {
                    Console.Write($"{studentNames[i]} Adlı Öğrencinin {j+1}. Sınav Notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult/3;
            }

            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++) 
            {
                Console.WriteLine("------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //öğrencilerin ortlamaası ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]}adlı öğrenci dersi geçti");
                }
                else 
                {
                    Console.WriteLine($"{studentNames [i]}Adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------") ;
            }






            #endregion


            Console.ReadKey();

        }
    }
}
