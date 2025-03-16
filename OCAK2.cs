
/*1-) C#’ta Kullanılan Temel Veri Tipleri Nelerdir?

C# dilinde kullanılan temel veri tipleri şunlardır:

- int: Tam sayılar için kullanılır (örneğin, 5, -10, 100).
- double: Ondalıklı sayılar (kesirli sayılar) için kullanılır (örneğin, 5.2, -3.14, 0.123).
- float: Yalnızca tek hassasiyetli ondalıklı sayılar için kullanılır. (genellikle double yerine tercih edilmez.)
- char: Tek bir karakter için kullanılır (örneğin, 'a', '1', '$').
- string: Karakter dizilerini (metinleri) temsil eder (örneğin, "Merhaba", "123").
- bool: Mantıksal değerler için kullanılır, yalnızca true veya false alabilir.
- decimal: Finansal hesaplamalar gibi yüksek hassasiyet gerektiren ondalıklı sayılar için kullanılır (örneğin, 5.99M).

2-) Aşağıdaki Değişkenlerin Bellek Kullanımını Karşılaştırın:

- int x = 5;
  - Bellek Kullanımı: 4 byte (32-bit).
  - Açıklama: int tipi, 32-bit işaretli tam sayılar için 4 byte bellek kullanır.

- double y = 5.2;
  - Bellek Kullanımı: 8 byte (64-bit).
  - Açıklama: double tipi, 64-bit ondalıklı sayılar için 8 byte bellek kullanır.

- string name = "Mehmet";
  - Bellek Kullanımı: Her karakter 2 byte alır (Unicode karakter seti). Bu durumda, "Mehmet" 7 karakterden oluştuğu için toplam 14 byte bellek kullanır. Ancak, string referans türü olduğu için ek olarak bellek üzerinde bir nesne referansı tutulur.
  - Açıklama: string referans tipi olduğu için bellek kullanımı daha karmaşıktır. Karakterlerin kendisi bellek üzerinde saklanırken, string'in yönetimi ve uzunluğu gibi ek bilgiler de eklenir.

  3 -) using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan ilk sayıyı al
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        // Kullanıcıdan ikinci sayıyı al
        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // Sayıların toplamını hesapla
        int toplam = sayi1 + sayi2;

        // Sonucu ekrana yazdır
        Console.WriteLine("Toplam: " + toplam);
    }
} */
