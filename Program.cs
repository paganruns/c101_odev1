using System;

class Program
{
    static void Main()
    {
        //IlkSoru();
        //IkinciSoru();
        //  UcuncuSoru();
        DorduncuSoru();

        void IlkSoru()
        {
            System.Console.WriteLine("Pozitif Bir Sayı Giriniz");
            int pozitif_sayi = Int32.Parse(Console.ReadLine());
            int[] sayilar = new int[pozitif_sayi];
            System.Console.WriteLine(pozitif_sayi.ToString() + " adet sayı giriniz");

            for (int i = 0; i < pozitif_sayi; i++)
            {
                System.Console.WriteLine("Sayıyı Giriniz");
                sayilar[i] = Int32.Parse(Console.ReadLine());

            }
            System.Console.WriteLine("Çift Sayılar aşağıdadır;");
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                    System.Console.WriteLine(item);
            }
        }

        void IkinciSoru()
        {
            System.Console.WriteLine("Pozitif Bir Sayı Giriniz");
            int n = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Oldu, Pozitif Bir Sayı Daha Giriniz");
            int m = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Şimdi " + n.ToString() + " adet sayı giriniz");


            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Sayıyı Giriniz");
                sayilar[i] = Int32.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"{m}'ye tam bölünenler  aşağıdadır;");
            foreach (var item in sayilar)
            {
                if (item == m || item % m == 0)
                    System.Console.WriteLine(item);

            }

        }

        void UcuncuSoru()
        {
            System.Console.WriteLine("Pozitif Bir Sayı Giriniz");
            int n = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Şimdi " + n.ToString() + " adet kelime giriniz");

            string[] kelimeler = new string[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine("Kelime Giriniz");
                kelimeler[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeler);

            System.Console.WriteLine("Kelimeler sondan başa doğru aşağıdadır.");
            foreach (string item in kelimeler)
            {
                System.Console.WriteLine(item);
            }
        }

        void DorduncuSoru()
        {
            System.Console.WriteLine("Bir Cümle Giriniz");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(' ');
            int harf = cumle.Count() - kelimeler.Count() + 1;

            System.Console.WriteLine("toplam kelime : " + kelimeler.Count());
            System.Console.WriteLine("harf sayısı (boşluklar hariç) : " + harf);


        }



    }

}