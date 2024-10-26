namespace patika_w5_TryCatch
{
    internal class Program
    {
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
    }
}
