using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tarih = "31.07.2023";

            Console.WriteLine("Ltfen bir doviz kuru secin :");
            Console.WriteLine("dolar :d, euro:e, pound: p");
            string paraBirimi = Console.ReadLine();
            Console.WriteLine("Lütfen dovize cevirmek isrediginiz tl miktarini girin : ");
            decimal tl = Convert.ToDecimal(Console.ReadLine());
            decimal sonuc = KurHesapla(tl,paraBirimi);

            if (sonuc == -1)
            {
                Console.WriteLine("Gecersiz para birimi");
            }
            else
            {
                Console.WriteLine("Tarih : " + tarih + " Alacaginiz döviz miktari : " + sonuc);
            }
            
            Console.Read();

        }

        static decimal KurHesapla(decimal tl,string paraBirimi)
        {
            decimal sonuc = -1;

            const decimal dolar = 27.55m;
            const decimal euro = 30.14m;
            const decimal pound = 32m;

            switch(paraBirimi)
            {
                case "d":
                    sonuc = tl / dolar;
                    break;
                case "e":
                    sonuc = tl / euro;
                    break;
                case "p":
                    sonuc = tl / pound;
                    break;
                default:
                    sonuc = -1;
                    break;
            }
            return sonuc;

            
        }
    }
}
