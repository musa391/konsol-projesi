using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisteme Hoşgeldiniz");

            Console.WriteLine("İsminizi Girin");
            Console.ReadLine();

            Console.WriteLine("Soyisminizi Girin");
            Console.ReadLine();

            Console.WriteLine("Doğum Tarihinizi Girin(gün/ay/yıl)");
            Console.ReadLine();

            Console.WriteLine("Şifrenizi Girin");
            int sifre = int.Parse(Console.ReadLine());

            if (sifre >= 0)
            {
                Console.WriteLine("Giriş başarılı");
            }
            else if (sifre <= 300)
            {
                Console.WriteLine("Giriş Başarısız");
            }
            else
            {
                Console.WriteLine("Geçersiz şifre");
            }

            Console.WriteLine("Personel bilgilendirme sistemine hoşgeldiniz");
            Console.ReadLine();

            Console.WriteLine("Hangi işlemi yapmak istersiniz?(1-Maaş sorgulama/2-Mesai ücretleri/3-Yemek Listesi/4-Prim Şartları");
            int secim = int.Parse(Console.ReadLine());

            int işçi = 100;
            int memur = 101;
            int tekniker = 102;
            int mühendis = 103;
            int müdür = 104;


            switch (secim)
            {
                case 1:
                    Console.WriteLine("Maaşınızı öğrenmek için lütfen personel numaranızı girin");
                    int personelNumara = int.Parse(Console.ReadLine());
                    if (personelNumara == işçi)
                    {
                        Console.WriteLine("Maaşınız: 23000 TL");
                    }
                    else if (personelNumara == memur)
                    {
                        Console.WriteLine("Maaşınız: 26000 TL");
                    }
                    else if (personelNumara == tekniker)
                    {
                        Console.WriteLine("Maaşınız: 28000 TL");
                    }
                    else if (personelNumara == mühendis)
                    {
                        Console.WriteLine("Maaşınız: 35000 TL");
                    }
                    else if (personelNumara == müdür)
                    {
                        Console.WriteLine("Maaşınız: 50000 TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz personel numarası");
                    }
                    break;
                case 2:
                    Console.WriteLine("Mesai ücretlerinizi öğrenmek için lütfen personel numaranızı girin");
                    int personelNo = int.Parse(Console.ReadLine());
                    if (personelNo == işçi)
                    {
                        Console.WriteLine("Mesai ücretiniz: 1000 TL");
                    }
                    else if (personelNo == memur)
                    {
                        Console.WriteLine("Mesai ücretiniz: 1200 TL");
                    }
                    else if (personelNo == tekniker)
                    {
                        Console.WriteLine("Mesai ücretiniz: 1400 TL");
                    }
                    else if (personelNo == mühendis)
                    {
                        Console.WriteLine("Mesai ücretiniz: 1600 TL");
                    }
                    else if (personelNo == müdür)
                    {
                        Console.WriteLine("Mesai ücretiniz: 1800 TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz personel numarası");
                    }
                    break;

                case 3:
                    Console.WriteLine("Yemek listesi için lütfen günü giriniz(1-Pazartesi/2-Salı/3-Çarşamba/4-Perşembe/5-Cuma");
                    int haftagun = int.Parse(Console.ReadLine());
                    if (haftagun == 1)
                    {
                        Console.WriteLine("Yemek listesi:  Körili tavuk, Pilav, Salata");
                    }
                    else if (haftagun == 2)
                    {
                        Console.WriteLine("Yemek listesi: Kuzu tandır, Patates püresi, Salata");
                    }
                    else if (haftagun == 3)
                    {
                        Console.WriteLine("Yemek listesi: Izgara köfte, Pilav, Salata");
                    }
                    else if (haftagun == 4)
                    {
                        Console.WriteLine("Yemek listesi: Balık, Patates kızartması, Salata");
                    }
                    else if (haftagun == 5)
                    {
                        Console.WriteLine("Yemek listesi: Etli sebze yemeği, Pilav, Salata");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz personel numarası");
                    }
                    break;
                case 4:
                    Console.WriteLine("Prim şartları için personel numaranızı girin");
                    int giris=int.Parse(Console.ReadLine()); 
                    
                    if(giris == 100)
                    {
                        Console.WriteLine("Çalışılan yılı giriniz");
                        int girisyıl = int.Parse(Console.ReadLine());
                        if(girisyıl>1)
                        {
                            Console.WriteLine("Prim ücretiniz 1000tl'dir");
                        }
                        else if(girisyıl<4 && girisyıl>2)
                        {
                            Console.WriteLine("Prim ücreti 3000tl'dir");
                        }
                        else if(girisyıl>5)
                        {
                            Console.WriteLine("Prim Ücretiniz 5000tl'dir");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz personel numarası");
                        }
                    }
                    else if (giris == 101)
                    {
                        Console.WriteLine("Çalışılan yılı giriniz");
                        int girisyıl = int.Parse(Console.ReadLine());

                        if (girisyıl > 1)
                        {
                            Console.WriteLine("Prim ücretiniz 2000tl'dir");
                        }
                        else if (girisyıl < 4 && girisyıl>2)
                        {
                            Console.WriteLine("Prim ücreti 4000tl'dir");
                        }
                        else if (girisyıl > 5)
                        {
                            Console.WriteLine("Prim Ücretiniz 6000tl'dir");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz personel numarası");
                        }
                    }
                    else if(giris == 102)
                    {
                        Console.WriteLine("Çalışılan yılı giriniz");
                        int girisyıl = int.Parse(Console.ReadLine());
                        if (girisyıl > 1)
                        {
                            Console.WriteLine("Prim ücretiniz 2500tl'dir");
                        }
                        else if (girisyıl < 4 && girisyıl > 2)
                        {
                            Console.WriteLine("Prim ücreti 4500tl'dir");
                        }
                        else if (girisyıl > 5)
                        {
                            Console.WriteLine("Prim Ücretiniz 6500tl'dir");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz personel numarası");
                        }
                    }
                    else if (giris == 103)
                    {
                        Console.WriteLine("Çalışılan yılı giriniz");
                        int girisyıl = int.Parse(Console.ReadLine());
                        if (girisyıl > 1)
                        {
                            Console.WriteLine("Prim ücretiniz 4000tl'dir");
                        }
                        else if (girisyıl < 4 && girisyıl > 2)
                        {
                            Console.WriteLine("Prim ücreti 6000tl'dir");
                        }
                        else if (girisyıl > 5)
                        {
                            Console.WriteLine("Prim Ücretiniz 8000tl'dir");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz personel numarası");
                        }
                    }

                    int aylıksatısı = 0;
                    if(giris==104)
                    {
                        if (aylıksatısı > 500)
                        {
                            Console.WriteLine("Priminiz 5000tl'dir");
                        }
                        else if (aylıksatısı < 900 && aylıksatısı > 600)
                        {
                            Console.WriteLine("Priminiz 8000tl'dir");
                        }
                        else if (aylıksatısı < 1500 && aylıksatısı > 1000) 
                        {
                            Console.WriteLine("Priminiz 10000tl'dir");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz personel numarası");
                        }
                    }

                    break;

                   

            }

            string bosluk = " ";
            Console.WriteLine(bosluk);

            Console.WriteLine("Çıkış için entera basınız");
            Console.ReadLine();


            Console.WriteLine("Sistemden memnun kaldınız mı?(Evet/Hayır)");
            bool memnunMu= bool.Parse(Console.ReadLine());

            if(memnunMu == true)
            {
                Console.WriteLine("Sistemden memnun kaldığınız için teşekkür ederiz");
            }
            else
            {
                Console.WriteLine("Geri bildirim için teşekkürler");
            }

            Console.WriteLine("Sistemden çıkış yapılıyor...");





        }
    }
}
              
              
            
        
    

