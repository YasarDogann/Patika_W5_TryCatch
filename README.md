# Patika+ Week5 Try-Catch Uygulaması
Merhaba,
Bu proje C# ile Patika+ 5.hafta Try-Catch için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Try-Catch yapısını anlamak


## İstenilen Görev
Bu pratikte basit bir try-catch uygulaması yapalım.
Kullanıcıdan bir sayı girmesini isteyen bir program yazın. Kullanıcı geçerli bir sayı girdiğinde bu sayının karesini ekrana yazdırınız. 
Kullanıcı geçersiz bir giriş yaparsa (sayı yerine harf veya sembol girmesi gibi), "Geçersiz giriş! Lütfen bir sayı giriniz." şeklinde bir hata mesajı gösteriniz.


## Kod 
```csharp
static void Main(string[] args)
{
    int number;

    try
    {
        // Potansiyel hata oluşturabilecek Kod 
        Console.Write("Sayı Gir: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("--------------------------------");

        Console.WriteLine($"Girilen sayı: {number}\r\nKaresi: "+number*number);

    }
    catch (FormatException ex)
    {
        // FormatException:  Bir dizeyi dönüştürmeye çalışırken hatalı bir format kullanıldığında.
        Console.WriteLine("HATA! Girilen Değer Sayı Olmalıdır. Geçerli Formatta Giriş Yapınız.");
    }

    Console.Read();
}
```





