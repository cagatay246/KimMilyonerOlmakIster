using System;

class Program
{
    static void Main()
    {
        // Sorular ve şıkları
        string[] sorular = {
            "1 -> Kızınca tüküren hayvan hangisidir ?",
            "2 -> Dünya'ya en yakın gezegen hangisidir ?",
            "3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ?"
        };

        string[,] sıklar = {
            { "a) Lama", "b) Deve" },
            { "a) Venüs", "b) Mars" },
            { "a) 7", "b) 12" }
        };

        // Doğru cevaplar
        char[] dogruCevaplar = { 'a', 'a', 'b' };  

        int dogruSayisi = 0;

        // 1. soru
        Console.WriteLine(sorular[0]);
        Console.WriteLine(sıklar[0, 0]);
        Console.WriteLine(sıklar[0, 1]);
        Console.Write("Cevabınızı girin (a/b): ");
        char cevap1 = char.ToLower(Console.ReadLine()[0]);  
        if (cevap1 == dogruCevaplar[0])
        {
            Console.WriteLine("Doğru cevap!");
            dogruSayisi++;
        }
        else
        {
            Console.WriteLine("Yanlış cevap.");
        }

        
        if (dogruSayisi == 1)
        {
            Console.WriteLine(sorular[1]);
            Console.WriteLine(sıklar[1, 0]);
            Console.WriteLine(sıklar[1, 1]);
            Console.Write("Cevabınızı girin (a/b): ");
            char cevap2 = char.ToLower(Console.ReadLine()[0]);  
            if (cevap2 == dogruCevaplar[1])
            {
                Console.WriteLine("Doğru cevap!");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap.");
            }
        }
        if(dogruSayisi == 1)
        {
            Console.WriteLine(sorular[2]);
            Console.WriteLine(sıklar[2, 0]);
            Console.WriteLine(sıklar[2, 1]);
            char cevap3 = char.ToLower(Console.ReadLine()[0]);
            if (cevap3 == dogruCevaplar[2])
            {
                Console.WriteLine("Doğru cevap");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap");
            }


        }





        // 2 sorudan 2 doğru cevap verildiyse 3. soruya gerek yok
        if (dogruSayisi >= 2)
        {
            Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("Büyük ödülü kazanamadınız. Daha iyi şanslar bir sonraki sefere!");
        }
    }
}

