﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            //2.4.6.8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //değişken türü[] DiziAdı=new değişken Türü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";
            //Console.WriteLine(cities[4]);

            //int[] numbers=new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[4] = 37;
            //    numbers[7] = 748;

            //Console.WriteLine(numbers[6]);

            //string[] cities = { "Prag", "Roma" ,"Atina","Ankara","Bursa"};


            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı" ,"Kırmızı","Beyaz","Mavi","Yeşil","Turuncu","Pembe"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4,85,75,96,125,635,488,522,7456,2365,1120};

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if(numbers[i] % 3 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 476, 45, 876, 20, 1000, 4467, 2346, 21, 567 };

            //int maxNumber=myArray[0];

            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if (myArray[i] > maxNumber) 
            //    {
            //    maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = {"Ali","Ahmet","Ayşe","Buse","Cem","Deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 2, 5, 678, 432, 876, 234, 876, 19 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 5, 678, 432, 876, 234, 876, 19 };
            //Array.(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[]numbers = {45,85,95,41,25,635,789,86,100 };

            //Console.WriteLine("Dizinin En Büyük Elemanı: "+numbers.Max()+" Dizin En Küçük Elemanı: "+numbers.Min());




            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] number = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++) 
            //{
            //sum += number[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = {21,42,33,54,55,66,897,748,39,220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 0) 
            //    {
            //    Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion            Console.ReadKey();

            Console.ReadKey(); 


        }
    }
}
