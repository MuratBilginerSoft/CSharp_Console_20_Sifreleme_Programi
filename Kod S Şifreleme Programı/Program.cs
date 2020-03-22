using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Şifreleme_Programı
{
    class Program
    {
        static void Main(string[] args)
        {
        git1:
            Console.Clear();
            Console.WriteLine("                                   ***********");
            Console.WriteLine("                                   *YAMU DİLİ*");
            Console.WriteLine("                                   ***********");
            for (int i = 0; i < 4; i++)
                Console.WriteLine();
            int b = 0;
            string c, d;
            Console.WriteLine(@"                            KELİME--->ŞİFRE        1

                            ŞİFRE --->KELİME       2

                            ÇIKIŞ                  3");

            for (int i = 0; i < 3; i++)
                Console.WriteLine();

            Console.WriteLine("                   ******************************");
            Console.WriteLine("                   *MURAT BİLGİNER & YAŞAR İSLAM*");
            Console.WriteLine("                   ******************************");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("                   ******************************");
            Console.WriteLine("                   *MURAT BİLGİNER & YAŞAR İSLAM*");
            Console.WriteLine("                   ******************************");

            Console.Clear();
            Console.WriteLine("                                   ***********");
            Console.WriteLine("                                   *YAMU DİLİ*");
            Console.WriteLine("                                   ***********");
            for (int i = 0; i < 3; i++)
                Console.WriteLine();

            // KELİME--->ŞİFRE BLOGU

            if (b == 1)
            {
                Console.WriteLine(@"                     BÜYÜK HARF KULLANACAKSANIZ        B/b

                     KÜÇÜK HARF KULANACAKSANIZ         K/k");

                c = Console.ReadLine();

                if (c == "B" || c == "b")
                {
                    Console.Clear();
                    Console.WriteLine("                                   ***********");
                    Console.WriteLine("                                   *YAMU DİLİ*");
                    Console.WriteLine("                                   ***********");

                    for (int i = 0; i < 3; i++)
                        Console.WriteLine();

                    Console.Write("KELİME/CÜMLE=");
                    string ad = Console.ReadLine();

                    char[] alfabe2 = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', ' ' };

                    int[] xx = new int[ad.Length];
                    char[] sifre = new char[ad.Length];

                    int adet = 0, y = 0, konum;

                    foreach (char x in ad)
                    {

                        konum = Array.IndexOf(alfabe2, x);
                        xx[adet] = konum;
                        adet++;
                    }
                    for (int i = 0; i < ad.Length; i++)
                    {


                        if (y % 2 == 0)
                        {
                            if (xx[i] == 28)
                                sifre[i] = 'A';

                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe2[xx[i] + 1];



                        }

                        else if (y % 2 != 0)
                        {
                            if (xx[i] == 0)
                                sifre[i] = 'Z';
                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe2[xx[i] - 1];
                        }
                        y++;
                    }
                    Console.WriteLine();
                    Console.Write("ŞİFRE=");
                    for (int i = 0; i < ad.Length; i++)
                    {
                        Console.Write(sifre[i]);
                    }

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine();

                    Console.WriteLine(@"                             ANA SAYFA            A/a

                                 ÇIKIŞ            C/c");
                    d = Console.ReadLine();

                    if (d == "A" || d == "a")
                        goto git1;

                    else if (d == "C" || d == "c")
                        goto git2;
                }

                else if (c == "K" || c == "k")
                {
                    Console.Clear();
                    Console.WriteLine("                                   ***********");
                    Console.WriteLine("                                   *YAMU DİLİ*");
                    Console.WriteLine("                                   ***********");

                    Console.Write("KELİME/CÜMLE=");
                    string ad = Console.ReadLine();

                    char[] alfabe1 = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z', ' ' };

                    int[] xx = new int[ad.Length];
                    char[] sifre = new char[ad.Length];

                    int adet = 0, y = 0, konum;

                    foreach (char x in ad)
                    {

                        konum = Array.IndexOf(alfabe1, x);
                        xx[adet] = konum;
                        adet++;
                    }
                    for (int i = 0; i < ad.Length; i++)
                    {


                        if (y % 2 == 0)
                        {
                            if (xx[i] == 28)
                                sifre[i] = 'a';

                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe1[xx[i] + 1];
                        }

                        else if (y % 2 != 0)
                        {
                            if (xx[i] == 0)
                                sifre[i] = 'z';
                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe1[xx[i] - 1];
                        }
                        y++;
                    }
                    Console.WriteLine();
                    Console.Write("ŞİFRE=");

                    for (int i = 0; i < ad.Length; i++)
                    {
                        Console.Write(sifre[i]);
                    }

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine();

                    Console.WriteLine(@"                             ANA SAYFA            A/a

                                 ÇIKIŞ            C/c");
                    d = Console.ReadLine();

                    if (d == "A" || d == "a")
                        goto git1;

                    else if (d == "C" || d == "c")
                        goto git2;
                }

            } // KELİME ŞİFRE BLOGU BİTTİ

            else if (b == 2)
            {
                Console.WriteLine(@"                     BÜYÜK HARF KULLANACAKSANIZ        B/b

                     KÜÇÜK HARF KULANACAKSANIZ         K/k");

                c = Console.ReadLine();

                if (c == "B" || c == "b")
                {
                    Console.Clear();
                    Console.WriteLine("                                   ***********");
                    Console.WriteLine("                                   *YAMU DİLİ*");
                    Console.WriteLine("                                   ***********");

                    Console.Write("ŞİFRE=");
                    string ad = Console.ReadLine();

                    char[] alfabe2 = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z', ' ' };

                    int[] xx = new int[ad.Length];
                    char[] sifre = new char[ad.Length];

                    int adet = 0, y = 0, konum;

                    foreach (char x in ad)
                    {

                        konum = Array.IndexOf(alfabe2, x);
                        xx[adet] = konum;
                        adet++;
                    }

                    for (int i = 0; i < ad.Length; i++)
                    {


                        if (y % 2 == 0)
                        {
                            if (xx[i] == 0)
                                sifre[i] = 'Z';

                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe2[xx[i] - 1];
                        }

                        else if (y % 2 != 0)
                        {
                            if (xx[i] == 28)
                                sifre[i] = 'A';
                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe2[xx[i] + 1];
                        }
                        y++;
                    }

                    for (int i = 0; i < 3; i++)
                        Console.WriteLine();
                    Console.WriteLine("                                  ŞİFRE ÇÖZÜLDÜ");
                    for (int i = 0; i < 3; i++)
                        Console.WriteLine();

                    Console.WriteLine();
                    Console.Write("KELİME/CÜMLE=");

                    for (int i = 0; i < ad.Length; i++)
                    {
                        Console.Write(sifre[i]);
                    }

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine();

                    Console.WriteLine(@"                             ANA SAYFA            A/a

                                 ÇIKIŞ            C/c");
                    d = Console.ReadLine();

                    if (d == "A" || d == "a")
                        goto git1;

                    else if (d == "C" || d == "c")
                        goto git2;
                }

                else if (c == "K" || c == "k")
                {
                    Console.Clear();
                    Console.WriteLine("                                   ***********");
                    Console.WriteLine("                                   *YAMU DİLİ*");
                    Console.WriteLine("                                   ***********");

                    Console.Write("ŞİFREYİ GİRİNİZ=");
                    string ad = Console.ReadLine();

                    char[] alfabe1 = { 'a', 'b', 'c', 'ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z', ' ' };

                    int[] xx = new int[ad.Length];
                    char[] sifre = new char[ad.Length];

                    int adet = 0, y = 0, konum;

                    foreach (char x in ad)
                    {

                        konum = Array.IndexOf(alfabe1, x);
                        xx[adet] = konum;
                        adet++;
                    }
                    for (int i = 0; i < ad.Length; i++)
                    {


                        if (y % 2 == 0)
                        {
                            if (xx[i] == 0)
                                sifre[i] = 'z';

                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe1[xx[i] - 1];
                        }

                        else if (y % 2 != 0)
                        {
                            if (xx[i] == 28)
                                sifre[i] = 'a';
                            else if (xx[i] == 29)
                                sifre[i] = ' ';
                            else
                                sifre[i] = alfabe1[xx[i] + 1];
                        }
                        y++;
                    }
                    for (int i = 0; i < 3; i++)
                        Console.WriteLine();
                    Console.WriteLine("                                  ŞİFRE ÇÖZÜLDÜ");
                    for (int i = 0; i < 3; i++)
                        Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("KELİME/CÜMLE=");

                    for (int i = 0; i < ad.Length; i++)
                    {
                        Console.Write(sifre[i]);
                    }

                    for (int i = 0; i < 5; i++)
                        Console.WriteLine();

                    Console.WriteLine(@"                             ANA SAYFA            A/a

                                 ÇIKIŞ            C/c");
                    d = Console.ReadLine();

                    if (d == "A" || d == "a")
                        goto git1;

                    else if (d == "C" || d == "c")
                        goto git2;
                }

            }



            else if (b == 3)
            {

                Console.WriteLine("                   ******************************");
                Console.WriteLine("                   *MURAT BİLGİNER & YAŞAR İSLAM*");
                Console.WriteLine("                   ******************************");

            }

            Console.ReadKey();

        git2:
            {
                Console.Clear();
                Console.WriteLine("                                   ***********");
                Console.WriteLine("                                   *YAMU DİLİ*");
                Console.WriteLine("                                   ***********");

                for (int i = 0; i < 3; i++)
                    Console.WriteLine();

                Console.WriteLine("                   ******************************");
                Console.WriteLine("                   *MURAT BİLGİNER & YAŞAR İSLAM*");
                Console.WriteLine("                   ******************************");

            }
        }
    }
}
