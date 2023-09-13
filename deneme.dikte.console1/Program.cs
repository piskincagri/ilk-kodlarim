using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme.dikte.console1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///// 1'den 100'e kadar olan sayilarin küplerini hesaplayan console uygulamasi.

            //for (int i = 1; i <= 100 ; i++)
            //{
            //    int kup = i * i * i;
            //    Console.WriteLine(i+ "Sayısının küpü:"+ kup);

            //}
            //Console.ReadLine();


            /////girilen sayının abundant (güçlü) sayı mı ya da deficient (güçsüz) 

            //Console.WriteLine("Lütfen bir sayı giriniz sayı güçsüz mü hesaplayacağım");
            //Console.WriteLine("Bir sayı giriniz:");

            //int sayi =Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //for (int i = 1; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        toplam += i;


            //    }
            //}
            //if (toplam >sayi)
            //{
            //    Console.WriteLine("Girmiş olduğunuz " + sayi + "sı" + "bir güçlü sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("Girmiş olduğunuz " + sayi + "sı" + "güçsüz bir sayıdır");
            //}

            //Console.ReadLine(); 

            ////girilen sayı çift ise yarısını , tek ise 2 katını alarak ekrana yazdıran console uygulamasi.
            ///
            //Console.WriteLine("Hoşgeldiniz. Şimdi size aşağıda gireceğiniz sayı çift ise yarısını, tek ise iki katını hesaplayacağım");
            //Console.WriteLine("Lütfen sayı giriniz:");

            //string girilensayi = Console.ReadLine();
            //int girilensayidegeri = 0;
            //girilensayidegeri = Convert.ToInt32(girilensayi);

            //if (girilensayidegeri % 2== 0)
            //{
            //    int sonuc = girilensayidegeri / 2;
            //    Console.WriteLine("Girdiğiniz çift sayının yarısı"+  sonuc+ "dır");
            //}
            //else
            //{
            //    int sonuc2 = girilensayidegeri * 2;
            //    Console.WriteLine("Girdiğiniz tek sayının iki katı" + sonuc2 + "dir.");
            //}

            //Console.ReadLine();
            Console.Write("Bir sayı girin: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[1000];
            int count = 0;

            while (n != 1)
            {
                numbers[count] = n;
                count++;

                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
            }

            numbers[count] = n;
            count++;

            int[] squares = new int[count];
            for (int i = 0; i < count; i++)
            {
                squares[i] = numbers[i] * numbers[i];
            }

            Array.Sort(squares);

            Console.WriteLine("Kareleri sıralanmış sayılar: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(squares[i] + " ");
            }
        }


    }

    }


    

