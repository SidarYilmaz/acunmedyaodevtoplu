/*
1-) C# Programlama Dili Nedir? Hangi Alanlarda Kullanılır?

C#, Microsoft tarafından geliştirilmiş modern, nesne yönelimli bir programlama dilidir. .NET Framework ve .NET Core üzerinde çalışır. C# dilini aşağıdaki alanlarda kullanabilirsiniz:

- Masaüstü Uygulamaları: Windows Forms veya WPF ile.
- Web Uygulamaları: ASP.NET ile.
- Oyun Geliştirme: Unity oyun motoru ile.
- Mobil Uygulamalar: Xamarin kullanarak Android ve iOS için.
- Veritabanı Uygulamaları: ADO.NET veya Entity Framework ile.

2-) Bir Programın Çalışması İçin Temel Bileşenler Nelerdir?

-Derleyici: Programın kaynak kodunu makine diline çeviren araçtır.
- RAM : Programın çalışırken kullanılan geçici bellek alanıdır.
- CPU : Programın komutlarını işleyen işlemcidir.
- Sabit Disk veya Depolama Birimi: Programın dosyalarını saklayan birimdir (örneğin, hard disk veya SSD).

3-) Kullanıcıdan Adını Alıp Ekrana Yazdıran Basit C# Programı


using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan isim al
        Console.Write("Lütfen adınızı girin: ");
        string ad = Console.ReadLine();

        // Ekrana yazdır
        Console.WriteLine("Merhaba, " + ad + "!");
    }
}
*/
