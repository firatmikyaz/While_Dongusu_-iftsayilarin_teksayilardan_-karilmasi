using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Dongusu_Çiftsayilarin_teksayilardan_çıkarilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi = 0;

            while (true)
            {
                Console.Write("Bir sayı giriniz?");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {
                    break;
                }

                if (sayi % 2 == 0)
                {
                    toplam = toplam + sayi;
                }
                else
                {
                    toplam = toplam - sayi;
                }
            }
            Console.Write("Sonuç:{0}", toplam);
            Console.ReadKey();
        }
    }
}
