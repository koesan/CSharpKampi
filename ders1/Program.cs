// Gerekli kütüphaneleri import et.
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region yazdırmakomutları

            // Console.Write() ekrana yazı yazmakta kullanılır
            // Console.WriteLine ekrana satır satır metin yazmak için kullanılır

			//Console.WriteLine("Merhaba Dünya");

            // Console.Read(); // terminalin ekranda beklemesini sağlar. 

			#endregion

			#region Değişkenler

            //String
			//string name; // ile string değerlerini tutan değişkenleri tanımlamakta kullanılır
			//name = "selam"; // Örnek değişken
			//Console.Write(name); // değişkeni ekrana yazma

			//string customerName = "Ali"; // bu şekilde daha kısa bir şekilde değerler tanımlanır
			//string customerSurname = "Çınar";
			//string customerPhone = "+90 500 400 30 20";
			//string customerEmail = "deneme@gmail.com";
			//string district = "Kadıköy";
			//string city = "İstanbul";

			//Console.WriteLine("**** Rezervasyon Kartı ****");
			//Console.WriteLine();
			//Console.WriteLine("-------------------------------------------------");
			//Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
			//Console.WriteLine("İletişim: " + customerPhone);
			//Console.WriteLine("Email Adresi: " + customerEmail);
			//Console.WriteLine("Adres: " + district + "/" + city);
			//Console.WriteLine("-------------------------------------------------");
            //Console.Read();

            // string degerlerinin tutan değişkenleri + işlemi ile birleştirilir.
            //string a = "ali ";
            //string b = "kaya";

            //Console.Write(a+b);
            //Console.Read();

            //çıktı ali kaya olacak

			//int
			//int number = 24; # İnt değişkenleri strngler gibi tanımlanır fark ise int de tamsayılar kullanılır
			//Console.WriteLine(number);

			//int hamburgerPrice = 300;
			//int cokePrice = 35;
			//int waterPrice = 10;
			//int friesPrice = 50;
			//int pizzaPrice = 250;
			//int lemonadePrice = 30;

			//Console.WriteLine("**** Restoran Menü Fiyatı ****");
			//Console.WriteLine();
			//Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
			//Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
			//Console.WriteLine("-----Kola: " + cokePrice + " TL");
			//Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
			//Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
			//Console.WriteLine("-----Su: " + waterPrice + " TL");
			//Console.WriteLine();
			//Console.WriteLine("**** Restoran Menü Fiyatı ****");
            //Console.Read();

            
            int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 250;
			int lemonadePrice = 30;
			int hamburgerCount = 3;
			int cokeCount = 3;
			int waterCount = 3;
			int friesCount = 1;
			int pizzaCount = 0;
			int lemonadeCount = 0;

			int totalHamgurgerPrice = hamburgerCount * hamburgerPrice; // nümerik sayıları tutan değişkenlerde +,-,/,* gibi işlemleri bu şekilde yapılıyor
			int totalCokePrice = cokeCount * cokePrice;
			int totalWaterPrice = waterCount * waterPrice;
			int totalFriesPrice = lemonadeCount * lemonadePrice;
			int totalPizzaPrice = friesCount * friesPrice;
			int totalLemonadePrice = pizzaCount * pizzaPrice;

			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
			Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
			Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
			Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
			Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
			Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

			Console.WriteLine();

			int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

			Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            Console.Read();

			#endregion
		}
	}
}