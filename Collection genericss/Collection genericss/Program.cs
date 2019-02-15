using System;
using System.Collections.Generic;


namespace Collection_genericss
{
    class Program
    {
        static void Main(string[] args)
        {
            //yeni sitring listesi yaratacağız

            var items = new List<string>();  // string biçiminde tanımladık

            //görüntüleyeck Listenin Sayısı ve Kapasitesini 

            Console.WriteLine("İtemleri eklemeden önce: "+ $"Count = {items.Count}; Capacity = {items.Capacity}");

            items.Add("red"); // listenin sonuna geldi
            items.Insert(0, "yellow"); // elimizle ilkini sarı yaptık
            Console.WriteLine("\n\n Ekledikten sonra itemler: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            Console.WriteLine("\nGösterilecek listedeki renksayısı döngüsü");
            for (var i = 0; i < items.Count; i++)
            {
                Console.WriteLine($" {items[i]}");
            }
            
            
            //görüntüleyecek colors using foreach

            Console.WriteLine("\nHer durum için listenin içeriğini göster");
            foreach (var item in items)
            {
                Console.WriteLine($" {item}");
            }

            items.Add("green"); //Listenin EN SONUNA EKLEDİK  içinden eleman almak istersek sondan çıkacak
            items.Add("yellow"); // sonda bu sefer sarı var


            // göstereceğiz listenin capasitesini ve sayıısnı ekledikten sonra
            Console.WriteLine("\n\n Ekledikten sonra itemler: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            Console.WriteLine("\n Listedeki yeni elemanlar");
            foreach (var item in items)
            {
                Console.WriteLine($" {item}");
            }

            items.Remove("yellow"); // sarıyı listeden çıkardık

            Console.WriteLine("\n\nSarısız liste");
            foreach (var item in items)
            {
                Console.WriteLine($" {item}");
            }

            items.RemoveAt(1); // birinciyi sildi yani birde yeşil vardı

            Console.WriteLine("\n\nYeşilsiz liste");
            foreach (var item in items)
            {
                Console.WriteLine($" {item}");
            }

            Console.WriteLine("\nSildikten sonraki itemler: " + $"Count = {items.Count}; Capacity = {items.Capacity}");

            // listede bir elemanı CONTAİNS ile kontrol edeceğiz

            Console.WriteLine("\n\"\red\" is " + 
                $"{(items.Contains("red") ? string.Empty : "not ")} in the list");
            Console.ReadKey();
            // KAPASİTE 2 KATI ARTARAK GİDİYOR 2 EKLERSEK 4 8 EKLERSEK 16 OLUYOR EKLEMEYE KARŞI
            // ZEKİCE....
        }
    }
}
