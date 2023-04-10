using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //555554444333221 ekrana yazan kod
            //for(int i = 5; i >0; i--)
            //{   
            //    Console.Write(i);
            //}

            //Operatörler

            //int sayi = 0;
            //int sayi1 = 12;
            //var sonuc = sayi + sayi1;
            //Console.WriteLine(sonuc);
            //Console.ReadLine();

            #region KararYapıları

            //Klavyeden girilen iki sayının toplamı
            //int s2;
            //int s1;
            //Console.WriteLine("Lütfen birinci sayi giriniz:");
            //s1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayi giriniz:");
            //s2 = Convert.ToInt32(Console.ReadLine());



            //if (s1>0 && s2>0)
            //{
            //    var sonuc = s1 + s2;
            //    Console.WriteLine($"Sayıların toplamı{sonuc} Sayi1:{s1}");
            //    //Console.WriteLine($"Sayıların toplamı {0} Sayi1:{1}",sonuc,s1);
            //    //Console.WriteLine($"Sayıların toplamı:" + sonuc);

            //}
            //else
            //{
            //    Console.WriteLine("Sayıları sıfırdan büyük giriniz!");

            //}

            //Console.ReadKey();


            //hesap makinası

            //int s2;
            //int s1;
            //string opt="";
            //gitt:
            //Console.WriteLine("Lütfen birinci sayi giriniz:");
            //s1 = Convert.ToInt32(Console.ReadLine());

            //git:
            //Console.WriteLine("Lütfen operatör giriniz");
            //opt = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayi giriniz:");
            //s2 = Convert.ToInt32(Console.ReadLine());



            //if (opt == "+")
            //{
            //    var sonuc = s1 + s2;
            //    s1 = sonuc;
            //    Console.Clear();
            //    Console.WriteLine($"Sayıların toplamı{s1}" );
            //    goto git;
            //}
            //else if (opt == "-") 
            //{
            //    var sonuc = s1 - s2;
            //    s1 = sonuc;
            //    Console.Clear();
            //    Console.WriteLine($"Sayıların çıkarma {s1}") ;
            //    goto git;
            //}
            //else if (opt == "*")
            //{
            //    var sonuc = s1 * s2;
            //    s1 = sonuc;
            //    Console.Clear();
            //    Console.WriteLine($"Sayıların çarpımı{s1}" );
            //    goto git;
            //}
            //else if (opt == "/")
            //{
            //    var sonuc = s1 / s2;
            //    s1 = sonuc;
            //    Console.Clear();
            //    Console.WriteLine($"Sayıların bölümü {s1}" );
            //    goto git;
            //}
            //else if (opt == "k")
            //{
            //    Console.WriteLine("Hesap makinası kapanıyor!");              



            //}

            //else if (opt == "c")
            //{
            //    Console.WriteLine("Temizlemek istiyorsanız c ye basın!");
            //    Console.Clear();
            //    goto gitt;

            //}
            //Console.ReadKey();

            //k ya basınca uygulama kapatsın

            // c ye basınca sıfırlasın ve goto koy uygulama başa dönsün

            #endregion
            #region switch

            //int sayi1;
            //int sayi2;
            //var sonuc=0;
            //string opt = "";

            //Console.WriteLine("Lütfen birinci sayıyı giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());


            //basadon:
            //Console.WriteLine("Lütfen operatörü /,+,-,* giriniz");
            //opt = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //switch (opt)
            //{
            //    case "+":
            //        sonuc = sayi1 + sayi2;
            //        sayi1 = sonuc;
            //        Console.Clear();
            //        Console.Write(sayi1);
            //        goto basadon;

            //    case "-":
            //        sonuc = sayi1 - sayi2;
            //        sayi1 = sonuc;
            //        Console.Clear();
            //        Console.Write(sayi1);
            //        break;
            //    case "*":
            //        sonuc = sayi1 * sayi2;
            //        sayi1 = sonuc;
            //        Console.Clear();
            //        Console.Write(sayi1);
            //        break;
            //    case "/":
            //        sonuc = sayi1 / sayi2;
            //        sayi1 = sonuc;
            //        Console.Clear();
            //        Console.Write(sayi1);
            //        break;

            //    case "k":


            //        Console.Clear();
            //        Console.Write("Uygulama kapanıyor");
            //        break;

            //}
            //Console.ReadKey();



            #endregion

            #region donguler

            //1.soru   555554444333221 çıktısı

            //for (int i = 5; i >0; i--)
            //{ 
            //    for(int j = 0; j < i; j++) 
            //    {
            //        Console.WriteLine(i);
            //    }                

            //}
            //Console.ReadLine();



            //2.soru 111112222333445 çıktısı


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.ReadLine();



            #endregion

            //klavyeden girilen pozitif sayıya kadar çift ve tek sayıları yazdırıp.bunların ayrı ayrı toplamını yazdır.


            //int sayi;
            //int toplamC = 0;
            //int toplamT = 0;

            //Console.WriteLine("Lütfen sayı giriniz");

            //basadon:
            //sayi = Convert.ToInt32(Console.ReadLine());

            //if (sayi > 0)
            //{
            //    for(int i = 1; i < sayi; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine($"{i} sayısı çiftir..");
            //            toplamC = toplamC + i;

            //        }
            //        else
            //        {
            //            Console.WriteLine($"{i} sayısı tektir..");
            //            toplamT = toplamT + i;

            //        }
            //    }
            //    Console.WriteLine($"Çift sayıların toplamı:{toplamC}\nTek sayıların toplamı:{toplamT}");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen pozitif sayı giriniz");
            //    goto basadon;
            //}



            //Console.ReadLine();

            //------------------------------------------------------------------------------

            //           *
            //          ***
            //        *******
            //       *********   
            //      ***********
            //          ***
            //          ***
            //          ***         çıktısını veren kod.



            //for(int i = 0; i < 5; i++)
            //   {
            //    Console.WriteLine();

            //       for (int j = 4 - i; j > 0; j--) 
            //       {
            //           Console.Write(" ");

            //       }
            //       for (int k = 0 ; k < 2*i+1 ; k++) 
            //       {
            //           Console.Write("*");

            //       }

            //   }

            //for(int x = 0; x < 3; x++)
            //   {
            //       Console.WriteLine();
            //       for(int y = 0; y < 3; y++)
            //       {
            //           Console.Write(" ");
            //       }
            //       for (int z = 0; z < 3; z++)
            //       {
            //           Console.Write("*");
            //       }
            //   }

            //           Console.ReadLine();

            #region while

            //int toplam = 0;
            //for(int i = 0; i < 10; i++)
            //{
            //    toplam = toplam + i;
            //}

            //---------------------------------------

            //int i = 1;
            //int toplam = 0;

            //while (i<=5)
            //{
            //    toplam = toplam + i;
            //    i++;

            //}
            //Console.WriteLine(toplam);

            //Console.ReadLine();
            #endregion

            #region diziler

            //int[] sayilar = new int[3];  //dizi 3 eleman alabilir.

            //for (int i = 0; i <3; i++)
            //{
            //    sayilar[i]= Convert.ToInt16(Console.ReadLine());
            //}
            //Console.Clear();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //-----------------------------------------------

            //int[] sayilar = { 5, 6, 7, 8 };
            //try
            //{
            //    Console.WriteLine(sayilar[4]);

            //}
            //catch 
            //{

            //    Console.WriteLine("dizinin sınırları arasında değil");
            //}


            //-----------------------------------------------------------

            //dizideki sayıları yazdır ve topla

            int[] sayilar = { 5, 6, 7, 8 };
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
                toplam = toplam + sayilar[i];
            }
            Console.WriteLine(toplam);

            Console.WriteLine("************");

            //foreach le yazdır
            foreach(var x in sayilar)
            {
                Console.WriteLine(x);
            }



            #endregion

            Console.ReadLine();

        }
    }
}
