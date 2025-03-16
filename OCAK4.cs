/*

1-) Döngüler (for, while) Ne İşe Yarar? Hangisi Hangi Durumda Kullanılır?

Döngüler, bir işlem bloğunun belirli bir koşul sağlandığı sürece tekrarlanmasını sağlar. Programlama dillerinde iki yaygın döngü türü bulunur: `for` ve `while`.

- **for Döngüsü**: Döngü sayısının önceden bilindiği durumlarda kullanılır. Yani, döngünün kaç kez çalışacağını baştan belirlediğimizde kullanılır. Genellikle sayaçlı döngülerde kullanılır.

- **while Döngüsü**: Döngü sayısının önceden bilinmediği, koşul sağlandığı sürece döngünün devam etmesi gereken durumlarda kullanılır. Döngü koşulu her zaman baştan kontrol edilir, bu yüzden koşul sağlanmazsa döngü hiç çalışmaz.

---

2-) 1’den 10’a Kadar Olan Sayıları Ekrana Yazdıran Bir for Döngüsü:

Aşağıdaki C# programı, 1'den 10'a kadar olan sayıları `for` döngüsü kullanarak ekrana yazdırır:


using System;

class Program
{
    static void Main()
    {
        // 1'den 10'a kadar olan sayıları yazdıran for döngüsü
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}


3-) Kullanıcıdan Alınan Bir Sayıya Kadar Olan Sayıların Toplamını Hesaplayan Bir Program:

Aşağıdaki C# programı, kullanıcıdan bir sayı alır ve bu sayıya kadar olan sayıların toplamını hesaplar:

using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan sayı al
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int toplam = 0;

        // 1'den girilen sayıya kadar olan sayıları topla
        for (int i = 1; i <= sayi; i++)
        {
            toplam += i; // toplam = toplam + i
        }

        // Sonucu ekrana yazdır
        Console.WriteLine("Toplam: " + toplam);
    }
}
*/