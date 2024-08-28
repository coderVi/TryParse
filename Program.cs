namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string değerler için boş dolu kontrolü");

            var degisken = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(degisken))
            {
                Console.WriteLine("dolu");
            }
            else 
            {
                Console.WriteLine("boş");
            }
            /*
                Bu kod, bir string değişkeninin boş olup olmadığını kontrol etmek için kullanılıyor. Kullanıcıdan alınan değeri 
                (Console.ReadLine()) alıyor ve bu değerin boş olup olmadığını kontrol ediyor.

                Eğer degisken boş değilse (string.IsNullOrWhiteSpace(degisken)), "dolu" mesajını yazdırıyor; 
                eğer boş veya sadece beyaz karakterlerden (boşluk, tab vb.) oluşuyorsa, "boş" mesajını yazdırıyor.

                Kod gayet düzgün ve basit. KISS prensibine uygun bir şekilde boş dolu kontrolü yapıyor
             */

            Console.WriteLine("int değerler için boş veya geçerli sayı kontrolü");

            var input = Console.ReadLine();
            int degiskenSayi;

            if (int.TryParse(input, out degiskenSayi))
            {
                Console.WriteLine("Geçerli bir sayı: " + degiskenSayi);
            }
            else
            {
                Console.WriteLine("Geçersiz bir giriş, sayı giriniz.");
            }

            /*
             input değerine bir TAM sayı ataması yapılıyor ama yapılan bu atama STRING olarak belleğe alınıyor bunu ilk önce Convert
            yapıp daha sonra bir interger tanıma atama yapmak gibi uzun yol izlemektense bunu yapabiliriz.
            */
            //Örneğin ;
            string input0 = Console.ReadLine();
            int result = 2;
            int.TryParse(input0, out int tempResult);
            result += tempResult;
            Console.WriteLine($"Test başarılı çıkan değer : {result}");

            // Convert Yönetemi;
            Console.WriteLine("Bir sayı giriniz");
            var ornek = Console.ReadLine();

            int ornek0 = Convert.ToInt32(ornek);  // ornek değişkenini int'e çevir ve ornek0'a ata

            Console.WriteLine($"Convert Testi başarılı çıkan değer : {ornek0}");

            // ornek0 değişkeninin tipini kontrol et
            Type tip = ornek0.GetType();
            Console.WriteLine(tip);  // Tip olarak "System.Int32" yazacaktır


        }
    }
}
