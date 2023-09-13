using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace deneme.dikte2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region /// YILDIZLAR İÇİNDE İSİM YAZDIRMA
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 6; j++)
            //    {
            //        if ((i == 2 && j == 1) || (i == 2 && j == 2) || (i == 2 && j == 3) || (i == 2 && j == 4) || (i == 2 && j ==5 ) || (i ==2 && j == 6))
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {

            //            Console.Write("*");
            //        }
            //        if ((i == 2 && j == 1))
            //        {
            //            Console.Write(" ÇAĞRI     * ");
            //        }
            //        else
            //        {

            //            Console.Write("  ");
            //        }

            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region//// MAAŞI VE ZAM ORANI GİRİLEN İŞÇİNİN NE KADAR ZAMLI MAAŞ ALACAĞINI HESAPLAYAN PROGRAM
            //// Personelin Maaşını Giriniz
            //// Personelin Zam oranını giriniz
            //// Personelin zamlı maaş tutarını ekranda belirtiniz.

            //Console.WriteLine("Merhaba Lütfen Personelin maaş tutarını giriniz:");
            //string personelMaas = Console.ReadLine();
            //int persmaasdegeri = 0;
            //persmaasdegeri = int.Parse(personelMaas);

            //Console.WriteLine("Lütfen Personelin Zam oranını giriniz");
            //string PersonelZamOrani = Console.ReadLine();
            //int perszamdegesi = int.Parse(PersonelZamOrani);

            //int hesaplananzam = persmaasdegeri + (persmaasdegeri * perszamdegesi / 100);

            //Console.Write("Personelin zamlı maaşı" + "" + hesaplananzam + "dir.");

            //Console.ReadKey();
            #endregion

            #region//GİRİLEN AYIN HANGİ MEVSİMDE OLDUĞUNU SÖYLEYEN PROGRAM

            ////Kullanıcıdan bir ay bilgisi iste
            //// Kullanıcın girdiği ayın hangi mevsime ait olduğunu tespit et
            /// Girilen ay bilgisinin hangi mevsimde olduğunu konsola yaz
            /// Switch i kullan

            //Console.WriteLine("Merhaba sizden takvimden bir ayın ismini girmenizi istiyorum");
            //     string girilenay = Console.ReadLine();

            //        switch (girilenay)
            //        {
            //        case "ARALIK":
            //            Console.WriteLine("KIŞ MEVSİMİNDESİNİZ");

            //            break;

            //        case "OCAK":
            //            Console.WriteLine("KIŞ MEVSİMİNDESİNİZ");

            //            break;
            //        case "ŞUBAT":
            //            Console.WriteLine("KIŞ MEVSİMİNDESİNİZ");

            //            break;
            //        case "MART":
            //            Console.WriteLine("İLKBAHAR MEVSİMİNDESİNİZ");

            //            break;
            //        case "NİSAN":
            //            Console.WriteLine("İLKBAHAR MEVSİMİNDESİNİZ");

            //            break;
            //        case "MAYIS":
            //            Console.WriteLine("İLKBAHAR MEVSİMİNDESİNİZ");

            //            break;
            //        case "HAZİRAN":
            //            Console.WriteLine("YAZ MEVSİMİNDESİNİZ");

            //            break;
            //        case "TEMMUZ":
            //            Console.WriteLine("YAZ MEVSİMİNDESİNİZ");

            //            break;
            //        case "AĞUSTOS":
            //            Console.WriteLine("YAZ MEVSİMİNDESİNİZ");

            //            break;
            //        case "EYLÜL":
            //            Console.WriteLine("SONBAHAR MEVSİMİNDESİNİZ");

            //            break;
            //        case "EKİM":
            //            Console.WriteLine("SONBAHAR MEVSİMİNDESİNİZ");

            //            break;
            //        case "KASIM":
            //            Console.WriteLine("SONBAHAR MEVSİMİNDESİNİZ");

            //            break;

            //         }
            //Console.ReadLine();

            #endregion

            #region ////GİRİLEN SAYIYA KADAR BÜTÜN ASAL SAYILARI YAZAN PROGRAM

            //// Örneğin 7 girdi ?  5 , 3 , 2 yazacak
            ///*
            // * kullanıcıdan sayi al
            // * tipini çevir
            // * girilen sayıya kadar bir döngü yapılacak 1-7 arası
            // * her bir sayının asal olduğunu bulan döngüyü hazırla
            // * döngü bittiği anda sayının asal olup olmadığını ekrana yazdır             * 
            // */

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi =int.Parse(Console.ReadLine());
            //// i = girilen sayının 2 den başlayarak tüm kendinden küçük sayılarını tek tek dolaşmak için yaratıldı.
            //int i = 2;
            //int sayac = 0;
            //// i<=sayi = girilen sayının asal olup olmadığını bulabilmek için.
            //while (i<sayi) 
            //{
            //    sayac = 0; 
            //    // j = girilen sayının kendinden küçük herhangi bir sayının asal olup olmadığına bakmak için yazıldı
            //    int j = 2;

            //    // j<i = girilen sayıya kadar ki her bir sayının geriye doğru asal olup olmadığına tek tek bakacak.
            //    while (j<i)
            //    {
            //        if (i%j==0)
            //        {
            //            sayac++;
            //        }
            //        j++;
            //    }
            //    if (sayac ==0)
            //    {
            //        Console.WriteLine($"{i} asaldir");
            //    }
            //    i++;
            //}

            //Console.ReadKey();

            #endregion

            #region DİZİYE SAYI TANIMLAMA

            /* kullanıcıdan sayi girmesi isteni.
             * kullanicinin girdiği her sayi bir dizi içerisinde tutulur.
             * kullanicidan alınan sayi dizi içerisinde var mi diye kontrol edilir.
             * eger varsa eklenmez yoksa diziye eklenir.
             * dizide 10 sayi olana kadar kullanici giriş yapabilir
             */


            //int[] sayilar = new int[10];

            //int sayac = 0;


            //do
            //{
            //    Console.WriteLine("sayı: ");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    bool sayiDizideVarMi = false;


            //    for (int i = 0; i < sayac; i++)
            //    {
            //        if (sayilar[i] == sayi)
            //        {
            //            sayiDizideVarMi = true;
            //            break;
            //        }
            //    }

            //    if (sayiDizideVarMi == false)
            //    {
            //        sayilar[sayac] = sayi;
            //        sayac++;
            //    }

            //} while (sayac < 10);

            //Console.WriteLine("sayılar: ");

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write(sayilar[i] + " ");
            //}

            //Console.ReadKey();

            #endregion


            #region/// NOT HESAPLAMA VE HARF DEĞERİNİ GÖSTEREN PROGRAM
            /// Kullanıcıdan Vize notunu iste
            /// Kullanıcıdan 2.vize notunu iste
            /// Kullanıcıdan final notunu iste
            /// notların ortalamasını al
            /// eğer not 80 - 100 arasında ise A+ hafr notunu ver
            /// eğer not 79-60 arasında ise A notunu ver
            /// eğer not 59-40 arasında ise B+ notunu ver
            /// eğer not 39-0 arasında ise F notunu ver
            /// Görüntüleme hem puan hem harf olarak olsun.

            //Console.WriteLine("Lütfen vize notunuzu giriniz:");
            //int vize1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Lütfen 2.vize notunuzu giriniz:");
            //int vize2 = Convert.ToInt32(Console.ReadLine());                 

            //Console.WriteLine("Lütfen Final notunuzu giriniz:");
            //int final = Convert.ToInt32(Console.ReadLine());

            //int ortalama = (vize1 + vize2 + final) / 3;
            //Console.WriteLine(" Sınav Ortalamanız:" +  ortalama);


            //if (ortalama >= 80 && ortalama <= 100)
            //{
            //    Console.WriteLine("Not değeriniz A+");

            //}
            //else if (ortalama >= 60 && ortalama <= 79)
            //{
            //    Console.WriteLine("Not değeriniz A");
            //}
            //else if (ortalama >= 59 && ortalama <= 40)
            //{
            //    Console.WriteLine("Not değeriniz B+");
            //}
            //else if (ortalama >=39 && ortalama <0)
            //{
            //    Console.WriteLine("Not değeriniz F");

            //}
            //Console.ReadKey();
            #endregion

            #region/// ATM Uygulaması
            ////// 1 e basarsa Bakiye görsün
            ////// 2 e basarsa Para çeksin
            //////3 e basarsa Para yatırsın
            ////// Q ya basarsa çıkış yapsın
            //////

            //Console.WriteLine("Merhaba ATM'ye hoşgeldiniz.");
            //Console.WriteLine("Lüfen kullanıcı adını giriniz");

            //int hak_Sayisi = 3;
            //decimal bakiye = 0m;
            //while (true)
            //{
            //    Console.WriteLine("Kullanıcı Adı:");
            //    string kullaniciadi = Console.ReadLine();
            //    Console.WriteLine("Kullanıcı Şifresi:");
            //    string sifre = Console.ReadLine();

            //    if (kullaniciadi == "Çağrı" && sifre == "123")
            //    {
            //        Console.WriteLine("Hoşgeldiniz");
            //        Console.ReadLine();


            //        bool devam = true;

            //        while (devam)
            //        {
            //            Console.WriteLine("Lütfen yapmak istedğiniz işlemi aşağıda belirtilen rakkamlar ile belirtiniz");
            //            Console.WriteLine("1 - Bakiye Sorma");
            //            Console.WriteLine("2- Para Çekme");
            //            Console.WriteLine("3 - Para Yatırma");
            //            Console.WriteLine("Q - Çıkış");
            //            Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız");

            //            string secim = Console.ReadLine();
            //            if (secim == "1")
            //            {
            //                Console.WriteLine("Şuanki bakiyeniz:" + bakiye.ToString("#.##0.00") + "'dir.");
            //                Console.ReadLine();
            //            }
            //            else if (secim == "2")
            //            {

            //                Console.WriteLine("Çekmek istediğiniz bakiyeyi giriniz:");
            //                decimal cekilecek_tutar = Convert.ToDecimal(Console.ReadLine());
            //                if (cekilecek_tutar <= bakiye)
            //                {
            //                    Console.WriteLine("Lütfen paranızı para çekme gözünden alınız");
            //                    bakiye = bakiye - cekilecek_tutar;
            //                    Console.WriteLine("Kalan bakiyeniz:" + " " + (bakiye.ToString("#.##0.00")) + "dir");
            //                    Console.ReadLine();
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Bakiyeniz Yetersizdir.");
            //                    Console.WriteLine("Güncel Bakiyeniz:" + bakiye.ToString("#.##0.00") + "dir.");
            //                    Console.ReadLine();
            //                }
            //            }
            //            else if (secim == "3")
            //            {

            //                Console.WriteLine("Lütfen yatırmak istediğiniz paranızı para yatırma gözüne yerleştiriniz");
            //                Console.WriteLine("Yatırılacak tutarı giriniz:");
            //                decimal yatirilacak_tutar = Convert.ToDecimal(Console.ReadLine());
            //                Console.WriteLine("Paranız hesabınıza yatmıştır.");
            //                bakiye = bakiye + yatirilacak_tutar;
            //                Console.WriteLine("Güncel Bakiyeniz " + (bakiye.ToString("#.##0.00")) + "dir.");
            //                Console.ReadLine();
            //            }
            //            else if (secim == "Q")
            //            {
            //                Console.WriteLine("Başka bir işlem yapmak istiyor musunuz? (E/H)");
            //                string cevap = Console.ReadLine();
            //                if (cevap == "H")
            //                {
            //                    Console.WriteLine("Program sonlandı.");
            //                    Console.ReadLine();

            //                }
            //                else if (cevap == "E")
            //                {
            //                    devam = true;

            //                }

            //            }

            //            else
            //            {
            //                Console.WriteLine("Lütfen gerçeli bir değer giriniz");
            //                Console.ReadLine();
            //                devam = true;
            //            }

            //        }
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalı lütfen tekrar deneyiniz.");
            //        if (hak_Sayisi > 0)
            //        {
            //            hak_Sayisi -= 1;
            //        }
            //        if (hak_Sayisi == 0)

            //        {
            //            Console.WriteLine("Şifrenizi 3 kere hatalı girdiniz.");
            //            Console.WriteLine("Hesaba erişim engellenmiştir. Lütfen bağlı olduğunuz şubenize gidiniz.");

            //            break;

            //        }

            //    }

            //}
            //Console.ReadLine();

            #endregion

            #region// FOR döngüsü ile 1 den 10 otomatik sayı yazdırma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            #endregion

            #region // For döngüsü ile 1 den 10 kadar sayılardan çift olanlarını ekrana yazdırmak

            //for (int a = 0; a <= 10; a = a + 1)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.ReadLine();
            #endregion

            #region // İç İçe FOR döngüsü ile 1 den 10 da erkana yazı yazmak
            //    for (int i =1; i<=10; i++)
            //    {
            //        for(int j=1; j<=i; j++)
            //        {
            //            Console.Write(j);
            //        }
            //        Console.WriteLine("");
            //    }
            //    Console.ReadLine(); 
            //}

            #endregion

            #region//WHİLE DÖNGÜSÜ

            /// 1 den 10a kadar olan sayılar yazdırın

            //int a = 1;
            //while (a <= 10)
            //{
            //    Console.WriteLine(a);
            //    a++;
            //}
            //Console.ReadLine();

            ///100 den 0 a kadar olan sayıların çift olanlarını büyükten küçüğe yazdırın
            //int a = 100;
            //while (a>0)
            //{
            //    Console.WriteLine(a);
            //    a = a - 2;
            //}

            //Console.ReadLine();

            #endregion

            #region// DO WHİLE DÖNGÜSÜ
            //// 1 Den 10 a kadar sayıları yazdıran program (do while ile)

            //int a = 1;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;

            //} while (a <= 10);

            //Console.ReadLine();


            //// 1 den 100 e kadr olan sayıların toplamını ekrana yazdıran (do while ile)

            //int a = 1;
            //int toplam = 0;
            //do
            //{
            //    toplam += a;
            //    a++;


            //} while (a<=100);
            //Console.WriteLine("1 DEN 100 E KADAR OLAN SAYILARIN TOPLAMI"+toplam);
            //Console.ReadLine();

            #endregion

            #region/// Break ve Continue anahtar kelimesi

            /// BREAK  Döngü 1 den 1O a kadar çalışıyor ancak  7 ye gelince döngü kırılıyor.
            //for (int a = 1; a <= 10; a++)
            //{
            //    if (a == 7)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("a değeri" + a);
            //}
            //Console.ReadLine();

            /// CONTUNUE  Döngü 1 den 10 kadar çalışır ancak 7 yi çalıştırmaz ve göstermez
            /// 
            //for (int a = 1; a <= 10; a++)
            //{
            //    if (a == 7)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("a değeri" + a);
            //}
            //Console.ReadLine();

            #endregion


            #region /// ÖDEV              

            //int[] sayilar = new int [0];

            //while (true)
            //{
            //    Console.WriteLine("Hoşgeldiniz sizden sayılar girmenizi istiyorum");

            //   int girilensayilar =int.Parse(Console.ReadLine());
            //    if( girilensayilar == 0 )
            //    {
            //        break;
            //    }
            //    Array.Resize(ref sayilar, sayilar.Length+1);
            //    sayilar[sayilar.Length-1] = girilensayilar; 

            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine($"Girdiğiniz sayılar:" +  sayilar[i]);
            //    Console.ReadLine();
            //}
            //Console.WriteLine("Şimdi bir seçim yapmanızı istiyorum");
            //Console.WriteLine("Seçtiğiniz sayıların karesini mi yoksa küğünü mü alalım?");
            //Console.WriteLine("Lütfen seçiminize göre KÜP veya KARE yazınız");
            //string secim = Console.ReadLine();

            //switch (secim)
            //{
            //    case "KARE":

            //        foreach (int kareler in sayilar)
            //        {
            //            int sayilar[i] = kareler % 2;

            //        }
            //        break;

            //}


            #endregion

            #region /// Switch - Case ile ATM uygulaması

            //int bakiye = 10000;
            //Console.WriteLine("ATM'ye hoşgeldiniz");

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            //Console.WriteLine("1- Bakiye Görüntüleme");
            //Console.WriteLine("2- Para Çekme");
            //Console.WriteLine("3- Para Yatırma");
            //Console.WriteLine("4- ATM'den Çıkış");

            //string secim = Console.ReadLine();

            //switch (secim)
            //{
            //    case "1":
            //        Console.WriteLine("Bakiyeniz:" + bakiye + "dir.");
            //        Console.ReadLine();
            //        break;

            //    case "2":
            //        int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

            //        if (cekilecekTutar > 10000)
            //        {
            //            Console.WriteLine("Bakiyeniz yetersizdir.");
            //            Console.WriteLine("Bakiyeniz" + bakiye + "dir.");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kalan bakiyeniz" + (bakiye - cekilecekTutar));
            //        }
            //        break;
            //    case "3":
            //        Console.WriteLine("Yatırmak istediğniz tutarı giriniz");
            //        Console.ReadLine();
            //        int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine("Yeni bakiyeniz" + (bakiye + yatirilacakTutar) + "dir");
            //        Console.ReadLine(); 
            //        break;

            //    default:
            //        Console.WriteLine("Lütfen geçerli bir değer giriniz");
            //        Console.ReadLine();
            //        break;

            //}
            #endregion

            #region // ÇARPIM TABLOSU

            //for(int i=1; i<=10; i++)
            //{
            //    for (int j=1; j<=10; j++)
            //    {
            //        Console.WriteLine(i + "X" + j + "=" + (i * j));

            //    }

            //}
            //Console.ReadLine();

            #endregion

            #region // TL cinsinden USD, EUR, POUND kuruna çevriren program

            bool devam = true;

            while (devam)
            {


                Console.WriteLine("Merhaba Parite Hesaplama Uygulamamıza Hoşgeldiniz");
                Console.WriteLine("Bugünün tarihi:" + " " + DateTime.Now);
                Console.WriteLine("Lütfen satın alacağınız dövizin kodunu giriniz");

                Console.WriteLine("1 - USD Kur Hesaplama");
                Console.WriteLine("2- EUR Kur Hesaplama");
                Console.WriteLine("3 -GPB Kur Hesaplama");


                string secim = Console.ReadLine();


                decimal usdkuru = 19.50m;
                decimal eurkuru = 21.50m;
                decimal gbpkuru = 24.60m;




                if (secim == "1")
                {
                    Console.WriteLine("Lütfen almak istedğiniz USD Tutarını giriniz");


                    decimal satinalinacakusdtutari = Convert.ToDecimal(Console.ReadLine());
                    if (satinalinacakusdtutari > 0)
                    {

                        decimal usdsonuc = 0m;
                        usdsonuc = Convert.ToDecimal(usdkuru * satinalinacakusdtutari);
                        Console.WriteLine(satinalinacakusdtutari + "USD Satın almak için" + " " + usdsonuc + " " + "TL ödemeniz gerekmektedir.");
                        Console.WriteLine(DateTime.Now);


                    }

                    Console.WriteLine("Tekrar hesaplama yapmak için bir tuşa basınız");

                    Console.ReadLine();
                    devam = true;

                }




                if (secim == "2")
                {
                    Console.WriteLine("Lütfen almak istedğiniz EUR Tutarını giriniz");


                    decimal satinalinacakeurtutari = Convert.ToDecimal(Console.ReadLine());
                    if (satinalinacakeurtutari > 0)
                    {

                        decimal eursonuc = 0m;
                        eursonuc = Convert.ToDecimal(eurkuru * satinalinacakeurtutari);
                        Console.WriteLine(satinalinacakeurtutari + "USD Satın almak için" + " " + eursonuc + "  " + "TL ödemeniz gerekmektedir.");
                        Console.WriteLine(DateTime.Now);


                    }
                    Console.WriteLine("Tekrar hesaplama yapmak için bir tuşa basınız");

                    Console.ReadLine();
                    devam = true;

                }

                if (secim == "3")
                {
                    Console.WriteLine("Lütfen almak istedğiniz GBP Tutarını giriniz");


                    decimal satinalinacakgbptutari = Convert.ToDecimal(Console.ReadLine());
                    if (satinalinacakgbptutari > 0)
                    {

                        decimal gbpsonuc = 0m;
                        gbpsonuc = Convert.ToDecimal(gbpkuru * satinalinacakgbptutari);
                        Console.WriteLine(satinalinacakgbptutari + "USD Satın almak için" + " " + gbpsonuc + "  " + "TL ödemeniz gerekmektedir.");
                        Console.WriteLine(DateTime.Now);

                    }

                    Console.WriteLine("Tekrar hesaplama yapmak için bir tuşa basınız");

                    Console.ReadLine();
                    devam = true;


                }
                else
                {
                    Console.WriteLine("********************************************");
                    Console.WriteLine("*LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ!(1, 2, 3)*");
                    Console.WriteLine("********************************************");
                    devam = true;

                }
            }


            #endregion


            #region// kullanıcı giriş sayfası uygulaması
            /*
             * Kullanıcı  kullanıcı adı ve şifresini doğru girerse hoşgeldiniz
             * yanlış girierse hata versin. 3 hak tanısın, kullanıcı yanlış girdiğinde
             * sürece döngü koysun devam etsin
             */

            //Console.WriteLine("Hoşgeldiniz");
            //Console.WriteLine("Lüfen kullanıcı adını giriniz");

            //int hak_Sayisi = 3;
            //while (true)
            //{
            //    Console.WriteLine("Kullanıcı Adı:");
            //    string kullaniciadi =Console.ReadLine();
            //    Console.WriteLine("Kullanıcı Şifresi:");
            //    string sifre = Console.ReadLine();

            //    if (kullaniciadi == "Çağrı" && sifre == "123")
            //    {
            //        Console.WriteLine("Hoşgeldiniz");
            //        Console.ReadLine();
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı adı hatalı lütfen tekrar deneyiniz.");
            //        if (hak_Sayisi>0)
            //        {
            //            hak_Sayisi -= 1;
            //        }
            //        if (hak_Sayisi == 0) 

            //        {
            //            Console.WriteLine("Hakkınız sona ermiştir.");

            //            break;

            //        }



            //    }

            //}
            //Console.ReadLine();






            #endregion

            #region /// METOTLAR

            //SelamVer();
            //SelamVer();
            //SelamVer();
            //SelamVer();
            //AdıniYazdir();
            //toplamaYap(5, 7);
            ////Console.ReadLine();
            //carpmaYap(5, 10, 8);
            //    int DonenDeger = toplamaYap(6, 7);
            //    if (DonenDeger > 10)
            //    {
            //        Console.WriteLine("Sayı toplamı 10'dan büyüktür");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayı değeri 10'dan küçüktür.");
            //    }
            //    Console.ReadLine(); 
            //}


            #region// Parametresiz -Geriye değer dönmeyen metot tanımlama...

            //static void SelamVer() // Metodun ismi selam ver olarak belirlendi.
            //{
            //    Console.WriteLine("Selamlar:");

            //}
            //static void AdıniYazdir()
            //{
            //    Console.WriteLine("ÇAĞRI PİŞKİN");
            //    Console.ReadLine();
            //}
            #endregion

            #region // Parametre Alan- Geriye Değer Döndürmeyen metot yazma



            //static void toplamaYap(int sayi1, int sayi2)

            //{

            //    Console.WriteLine("Gönderilen Sayıların Toplamı:"+ (sayi1+ sayi2));

            //}

            //static void carpmaYap(int sayi1, int sayi2, int sayi3)
            //{
            //    Console.WriteLine("Üç sayının çarpımı:" + (sayi1*sayi2*sayi3));
            //    Console.ReadLine();

            //}


            #endregion

            #region// Parametre alan- Geriye Değer Döndüren Metot yazma

            //    //return anahtar kelimesi
            //    //metot sonu
            //    static int toplamaYap(int sayi1 ,int sayi2)
            //{
            //    int sonuc = sayi1 + sayi2;

            //    return sonuc;
        }


        #endregion

        #endregion
    }

    }
}      

    


