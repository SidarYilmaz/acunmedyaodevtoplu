/*

1-) Koşullu İfadeler (if-else) Ne İşe Yarar? Gerçek Hayattan Bir Örnek Verin.

Koşullu ifadeler, belirli bir şartın sağlanıp sağlanmadığını kontrol etmek için kullanılır. Eğer şart doğruysa belirli bir işlem yapılır, yanlışsa başka bir işlem gerçekleştirilir. C# dilinde en yaygın kullanılan koşullu ifadeler if, else, else if yapılarına sahiptir.

Gerçek Hayat Örneği:
Bir otomobilin çalışıp çalışmadığını kontrol eden bir sistem düşünün. Eğer araçta yeterli yakıt varsa, araç çalışabilir (başka bir işlem yapılır). Eğer yakıt yoksa, araç çalışmaz (başka bir işlem yapılır). Burada yakıt miktarı bir şarttır ve bu şart doğru veya yanlış olduğunda farklı işlemler yapılır.

2-) Kullanıcıdan Bir Sayı Alıp Tek Mi Çift Mi Olduğunu Bulan Bir C# Programı:

Aşağıdaki program, kullanıcıdan bir sayı alıp, sayının tek mi yoksa çift mi olduğunu kontrol eder:


using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan sayı al
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        // Sayı çift mi, tek mi kontrol et
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }
    }
}

Bu programda:
- `sayi % 2 == 0` ifadesi, sayının çift olup olmadığını kontrol eder. Eğer kalansız bölünebiliyorsa çift, aksi takdirde tek olduğunu belirtir.

3-) Girilen Bir Sayının Pozitif, Negatif veya Sıfır Olup Olmadığını Belirleyen Bir Program:

Aşağıdaki C# programı, girilen bir sayının pozitif, negatif veya sıfır olduğunu kontrol eder:


using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir sayı al
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        // Sayıyı kontrol et
        if (sayi > 0)
        {
            Console.WriteLine("Girilen sayı pozitiftir.");
        }
        else if (sayi < 0)
        {
            Console.WriteLine("Girilen sayı negatiftir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı sıfırdır.");
        }
    }
}  */
