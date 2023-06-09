using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomat_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] urunler = { "Kola", "Cips", "Su", "Soğuk Çay", "Çikolata", "Karam", "Canga" };
            int[] fiyatlar = { 5, 6, 2, 3, 4, 5, 6 };

            while (true)
            {


                Console.WriteLine("Ürünler listeleniyor....");
                Console.WriteLine("0-Admin Girişi");
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine((1 + i) + "-" + urunler[i] + "-> " + fiyatlar[i] + " TL");
                }


                Console.WriteLine("Hangi ürünü almak istersiniz? ");
                int select = Convert.ToInt32(Console.ReadLine());

                //Admin işlemleri    
                if (select == 0)
                {
                    Console.WriteLine("Kullanıcı adı girin...");
                    string name = Console.ReadLine();
                    Console.WriteLine("Şifre girin...");
                    string password = Console.ReadLine();
                    if (password == "123" && name == "admin")
                    {
                        Console.WriteLine("Giriş başarılı..");
                        Console.WriteLine("Ürünler listeleniyor....");
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine((1 + i) + "-" + urunler[i] + "-> " + fiyatlar[i] + " TL");
                        }
                        Console.WriteLine("Ürün eklemek ister misiniz? (E-H)");
                        string answer = Console.ReadLine();
                        if (answer == "e" || answer == "E")
                        {

                        urunListele:
                            Console.WriteLine("Ürün adı girin...");
                            string urunAdi = Console.ReadLine();
                            Console.WriteLine("Ürün fiyatı girin...");
                            int urunFiyati = Convert.ToInt32(Console.ReadLine());

                            Array.Resize(ref urunler, urunler.Length + 1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length + 1);

                            urunler[urunler.Length - 1] = urunAdi;
                            fiyatlar[fiyatlar.Length - 1] = urunFiyati;

                            Console.WriteLine("Ürün eklendi...");
                            Console.WriteLine("Ürünler listeleniyor....");
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine((1 + i) + "-" + urunler[i] + "-> " + fiyatlar[i] + " TL");
                            }
                            Console.WriteLine("Ürün eklemek ister misiniz? (E-H)");
                            string answer2 = Console.ReadLine();
                            if (answer2 == "e" || answer2 == "E")
                            {
                                goto urunListele;
                            }
                            else
                            {
                                Console.WriteLine("Çıkış yapılıyor...");
                                break;
                            }
                            goto urunListele;
                        }
                        else
                        {
                            Console.WriteLine("Ürün eklenmedi...");
                            break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("Giriş başarısız..");
                        break;
                    }
                }


            paraGiris:
                Console.WriteLine("Parayı girin->");
                int money = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ürün hazırlanıyor...");

                if (money >= fiyatlar[select - 1])
                {
                    Console.WriteLine("Ürün hazır");
                    Console.WriteLine("Para üstü: " + (money - fiyatlar[select - 1]) + " TL");
                    Console.WriteLine("Yeni ürün almak ister misiniz? (E-H)");
                    string answer = Console.ReadLine();

                    if (answer == "E" || answer == "e")
                    {
                        goto paraGiris;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye");

                    Console.WriteLine("Tekrar denemek ister misiniz?");

                    string answer = Console.ReadLine();
                    if (answer == "E" || answer == "e")
                    {
                        goto paraGiris;
                    }
                }

            }
        }
    }
}
