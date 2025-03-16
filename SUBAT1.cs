/*
1-) Array Nedir? Ne İşe Yarar? Gerçek Hayattan Bir Örnek Verin.

Dizi (Array), aynı türdeki birden fazla veriyi tek bir değişken altında depolamak için kullanılan veri yapısıdır. Diziler, özellikle birden fazla öğeyi saklamak ve bu öğelere erişim sağlamak için kullanılır. Her öğeye bir indeks (sıra numarası) aracılığıyla erişilir.

Gerçek Hayat Örneği:  
Bir sınıftaki öğrencilerin notlarını saklamak isteyen bir öğretmen düşünün. Öğrencilerin her biri için ayrı bir değişken oluşturmak yerine, hepsinin notlarını tek bir dizi içerisinde tutabiliriz. Örneğin, 30 öğrencinin notları 30 elemanlı bir dizide saklanabilir.


2-) 5 Elemanlı Bir int Dizisi Oluşturup, Kullanıcıdan Aldığı Değerlerle Diziyi Dolduran ve Ekrana Yazdıran Bir Program:



using System;

class Program
{
    static void Main()
    {
        // 5 elemanlı bir dizi oluşturuluyor
        int[] dizi = new int[5];

        // Kullanıcıdan diziyi dolduracak değerleri al
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Dizinin {0}. elemanını girin: ", i + 1);
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Diziyi ekrana yazdır
        Console.WriteLine("Dizinin elemanları:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(dizi[i]);
        }
    }
}

3-) Bir Dizinin İçindeki En Büyük Sayıyı Bulan Bir C# Programı:




using System;

class Program
{
    static void Main()
    {
        // Örnek bir dizi oluşturuluyor
        int[] dizi = { 3, 5, 7, 2, 8, 1, 4 };

        // En büyük sayıyı bulmak için bir değişken tanımlanıyor
        int enBuyuk = dizi[0];

        // Dizinin her elemanını kontrol et
        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }
        }

        // Sonucu ekrana yazdır
        Console.WriteLine("Dizinin en büyük sayısı: " + enBuyuk);
    }
}
*/