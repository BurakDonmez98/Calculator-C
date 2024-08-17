using System;

class Program
{


    static void Main()
    {

        string gecersizSayiMesaji = "Geçersiz giriş. Lütfen bir tam sayı girin: ";
        while (true)
        {
            try
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıkarma");
                Console.WriteLine("3. Çarpma");
                Console.WriteLine("4. Bölme");
                Console.WriteLine("5. Mod Alma");
                Console.WriteLine("0. Çıkış");

                int secim = int.Parse(Console.ReadLine());

                if (secim == 0)
                {
                    Console.WriteLine("Programdan çıkılıyor!!!");
                    break;
                }

                if (secim < 1 || secim > 5)
                {
                    Console.WriteLine("Geçersiz işlem seçimi. Lütfen tekrar deneyin.");
                    continue;
                }

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Seçiminiz: Toplama işlemi");
                        break;
                    case 2:
                        Console.WriteLine("Seçiminiz: Çıkarma işlemi");
                        break;
                    case 3:
                        Console.WriteLine("Seçiminiz: Çarpma işlemi");
                        break;
                    case 4:
                        Console.WriteLine("Seçiminiz: Bölme işlemi");
                        break;
                    case 5:
                        Console.WriteLine("Seçiminiz: Mod alma işlemi");
                        break;
                }

                if (secim == 5)
                {
                    int sayi1, sayi2;

                    Console.Write("Birinci tam sayıyı girin: ");
                    while (!int.TryParse(Console.ReadLine(), out sayi1))
                    {
                        Console.Write(gecersizSayiMesaji);
                    }

                    Console.Write("İkinci tam sayıyı girin: ");
                    while (!int.TryParse(Console.ReadLine(), out sayi2))
                    {
                        Console.Write(gecersizSayiMesaji);
                    }

                    Console.WriteLine("Sonuç: " + (sayi1 % sayi2));
                }
                else
                {
                    double sayi1, sayi2;

                    Console.Write("Birinci sayıyı girin: ");
                    while (!double.TryParse(Console.ReadLine(), out sayi1))
                    {
                        Console.Write(gecersizSayiMesaji);
                    }

                    Console.Write("İkinci sayıyı girin: ");
                    while (!double.TryParse(Console.ReadLine(), out sayi2))
                    {
                        Console.Write(gecersizSayiMesaji);
                    }

                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                            break;
                        case 2:
                            Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                            break;
                        case 3:
                            Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                            break;
                        case 4:
                            if (sayi2 == 0)
                            {
                                Console.WriteLine("Bölen 0 olamaz! Lütfen başka bir sayı girin.");
                            }
                            else
                            {
                                Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            Console.WriteLine();
        }
    }
}
