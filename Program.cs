using System;
using System.Collections.Generic;

namespace Antrenmanlar2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisiler = new List<Kisi>();
        ANAMENUDON:
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listele");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Kisi kisi = new Kisi();
                    kisiler.Add(kisi.KisiYarat());
                    Console.WriteLine("Tekrar işlem yapmak istiyor musunuz (Evet:E / Hayır:h)");
                    char o = Convert.ToChar(Console.ReadLine().ToLower());
                    if (o == 'e')
                        goto ANAMENUDON;
                    else
                    {
                        Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                        Console.WriteLine("İyi Günler ^^");
                        break;
                    }

                case 2:
                SİLMEİSLEMİDON:
                    Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                    string silinecek = Console.ReadLine();
                    int count = 0;
                    for (int item = 0; item < kisiler.Count; item++)
                    {
                        if (kisiler[item].Name == silinecek || kisiler[item].Surname == silinecek)
                        {
                            kisiler.RemoveAt(item);
                            Console.WriteLine("Silme işlemi Başarılı.");
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("Silmeyi Sonlandırmak için : (1)");
                        Console.WriteLine("Yeniden denemek için      : (2)");
                        char s = Convert.ToChar(Console.ReadLine().ToLower());
                        if (s == '2')
                        {
                            goto SİLMEİSLEMİDON;
                        }
                        else
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                            goto ANAMENUDON;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                        goto ANAMENUDON;
                    }
                case 3:
                GUNCELLEMEDON:
                    Console.WriteLine("Lütfen Güncellemek istediğiniz kişinin adını yada soyadını giriniz");
                    string güncellenecek = Console.ReadLine();
                    int count3 = 0;
                    foreach (var item in kisiler)
                    {
                        if (item.Name == güncellenecek || item.Surname == güncellenecek)
                        {
                            Console.WriteLine("Lütfen Yeni Numarayı Giriniz:");
                            string yeninumara = Console.ReadLine();
                            item.PhoNumber = yeninumara;
                            count3++;
                            Console.WriteLine("İşlem Başarılı, Güncel Numara : {0}",yeninumara);
                            Console.WriteLine("Ana Menuye Yonlendiriliyorsunuz.");
                            goto ANAMENUDON;
                        }
                    }
                    if (count3 == 0)
                    {
                        Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                        Console.WriteLine("Yeniden denemek için           : (2)");
                        char g = Convert.ToChar(Console.ReadLine().ToLower());
                        if (g == '2')
                            goto GUNCELLEMEDON;
                        else
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz");
                            goto ANAMENUDON;
                        }

                    }
                    break;
                case 4:
                    Console.WriteLine("Telefon Rehberi");
                    Console.WriteLine("******************************************");
                    if (kisiler != null)
                    {


                        foreach (var item in kisiler)
                        {
                            Console.WriteLine("isim : {0}", item.Name);
                            Console.WriteLine("Soyisim : {0}", item.Surname);
                            Console.WriteLine("Telefon Numarası : {0}", item.PhoNumber);
                            Console.WriteLine("-");
                        }
                        Console.WriteLine("Tekrar işlem yapmak istiyor musunuz (Evet:E / Hayır:h)");
                        char p = Convert.ToChar(Console.ReadLine().ToLower());
                        if (p == 'e')
                            goto ANAMENUDON;
                        else
                        {
                            Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                            Console.WriteLine("İyi Günler ^^");
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Rehberde Kişi Bulunamadı! Anamenuye Döndürülüyorsunuz.");
                        goto ANAMENUDON;
                    }
                case 5:
                CASE5_DON:
                    Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                    Console.WriteLine("*********************************************");

                    Console.WriteLine("İsim veya soyisime göre arama yapmak için (1)");
                    Console.WriteLine("Telefon numarasına göre arama yapmak için (2)");
                    char rehberAramaVeri = Convert.ToChar(Console.ReadLine());
                    if (kisiler.Count == 0) 
                    { 
                        Console.WriteLine("Rehber Boş Ana menuye Yönlendiliriyorsunuz");
                        goto ANAMENUDON;
                    }
                    if (rehberAramaVeri == '1')
                    {
                    REHBERDE_ARA:
                        Console.WriteLine("İsimi yada soyismi giriniz.");
                        string case5İsimAlma = Console.ReadLine();
                        int count1 = 0;
                        foreach (var item in kisiler)
                        {
                            if (item.Name == case5İsimAlma || item.Surname == case5İsimAlma)
                            {
                                Console.WriteLine("isim : {0}", item.Name);
                                Console.WriteLine("Soyisim : {0}", item.Surname);
                                Console.WriteLine("Telefon Numarası : {0}", item.PhoNumber);
                                count1++;
                            }
                        }
                        if (count1 == 0)
                        {
                            Console.WriteLine("Aradığınız Kriterlere Uygun Veri Bulunamadı. Tekrar Deneyiniz");
                            goto REHBERDE_ARA;
                        }
                        else
                        {
                            Console.WriteLine("Tekrar işlem yapmak istiyor musunuz (Evet:E / Hayır:h)");
                            char w = Convert.ToChar(Console.ReadLine().ToLower());
                            if (w == 'e')
                                goto ANAMENUDON;
                            else
                            {
                                Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                                Console.WriteLine("İyi Günler ^^");
                                break;
                            }
                        }
                    }
                    else if (rehberAramaVeri == '2')
                    {
                        Console.WriteLine("Telefon numarasını giriniz.");
                        string case5NumaraAlma = Console.ReadLine();
                        int count2 = 0;
                        foreach (var item in kisiler)
                        {
                            if (item.PhoNumber == case5NumaraAlma || item.PhoNumber == case5NumaraAlma)
                            {
                                Console.WriteLine("isim : {0}", item.Name);
                                Console.WriteLine("Soyisim : {0}", item.Surname);
                                Console.WriteLine("Telefon Numarası : {0}", item.PhoNumber);
                                count2++;
                                Console.WriteLine(" ");
                                Console.WriteLine("Tekrar işlem yapmak istiyor musunuz (Evet:E / Hayır:h)");
                                char u = Convert.ToChar(Console.ReadLine().ToLower());
                                if (u == 'e')
                                    goto ANAMENUDON;
                                else
                                {
                                    Console.WriteLine("Çıkış İşlemi Yapılıyor...");
                                    Console.WriteLine("İyi Günler ^^");
                                    break;
                                }

                            }
                        }
                        if (count2 == 0)
                        {
                            Console.WriteLine("Aradığınız Kriterlere Uygun Veri Bulunamadı. Anamenüye Dönüyorsunuz");
                            goto ANAMENUDON;
                        }
                    }
                    break;
            }
        }
    }
}
