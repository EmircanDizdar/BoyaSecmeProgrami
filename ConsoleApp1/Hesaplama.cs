using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hesaplama
    {
        private string[] renklerAdi = { "Beyaz", "Gri", "Kahverengi", "Mavi", "Mor", "Pembe", "Sari", "Siyah", "Yesil" };
        private int[] renkFiyati = { 36, 36, 40, 37, 35, 35, 40, 40, 37 };
        private int belirtec = 0;
        private int adet = 0;
        private int secenek = 0;
        private string tanim = "";
        private bool whileDongu = true;
        private bool switchDongu = true;
        public int[] renkEkleme(int[] renkler)
        {
            Console.Clear();
            renkAdi();
            whileDongu = true;
            switchDongu = true;
            while (whileDongu)
            {
                tanim = "Eklemek";
                Console.WriteLine("\nHangi rengi eklemek istiyorsunuz: ?");
                belirtec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nKac adet istiyorsunuz: ?");
                adet = Convert.ToInt32(Console.ReadLine());
                renkler[belirtec] += adet;
                switchDongusu();
            }

            return renkler;
        }

        public void renkCikarma(int[] renkler)
        {
            Console.Clear();
            renkAdi();
            whileDongu = true;
            switchDongu = true;
            while (whileDongu)
            {
                tanim = "Cikarmak";
                Console.WriteLine("\nHangi rengi cikarmak istiyorsunuz: ?");
                belirtec = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nKac adet cikarmak istiyorsunuz: ?");
                adet = Convert.ToInt32(Console.ReadLine());
                if (renkler[belirtec] - adet < 0)
                {
                    Console.WriteLine("\nÇıkarmak istediğiniz adet mevcut adetten fazladır. İşlem gerçekleştirilmemiştir.");
                }
                else
                {
                    renkler[belirtec] -= adet;
                }

                switchDongusu();
            }
        }

        public void renkArama(int[] renkler)
        {
            int toplamUcret = 0;
            bool renkAlimiVar = false;
            Console.WriteLine("\n");
            for (int i = 0; i < renklerAdi.Length; i++)
            {
                if (renkler[i] > 0)
                {
                    renkAlimiVar = true;
                    toplamUcret += renkFiyati[i] * renkler[i];
                    Console.WriteLine("{0} renginden {1} tane aldiniz. Adet Basina Ucreti: {2}₺", renklerAdi[i], renkler[i], renkFiyati[i]);
                }
            }

            if (renkAlimiVar == false)
            {
                Console.WriteLine("Herhangi bir renk seçmediniz.\n");
            }

            Console.WriteLine("\nToplam Ucretiniz: {0}₺", toplamUcret);
        }

        public void switchDongusu()
        {
            whileDongu = true;
            switchDongu = true;
            while (switchDongu)
            {
                Console.WriteLine("\n{0} istediginiz baska renk var mı (1 Evet/ 0 Hayır): ? ", tanim);
                secenek = Convert.ToInt32(Console.ReadLine());
                switch (secenek)
                {
                    case 0:
                        whileDongu = false;
                        switchDongu = false;
                        continue;
                    case 1:
                        switchDongu = false;
                        break;
                    default:
                        Console.WriteLine("Hatalı parametre girdiniz.");
                        break;
                }
            }
        }

        public void renkAdi()
        {
            Console.WriteLine("Renkler sayilara karsilik degerleri verilmistir bunlar sirasiyla;\n\nRenkler ----- Ucret(₺)\n0-Beyaz ----- 36₺/kg \n1-Gri ------- 36₺/kg \n2-K.Rengi --- 40₺/kg \n3-Mavi ------ 37₺/kg\n4-Mor ------- 35₺/kg\n5-Pembe ----- 35₺/kg\n6-Sari ------ 40₺/kg \n7-Siyah ----- 40₺/kg \n8-Yesil ----- 37₺/kg");
        }
    }
}
