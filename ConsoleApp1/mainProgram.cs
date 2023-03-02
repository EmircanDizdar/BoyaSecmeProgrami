using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class mainProgram
	{
		/* 
			------------------------------------------------------TANIMLAR------------------------------------------------------
			
			---MAIN CLASS'IN ICERSINDEKI;
			
			int[] renkler = Kullanıcı girdiği renk adetlerini tutar.
			
			int mainSecim = Kullanıcının girdiği menüdeki numarayı tutar.
			
			bool mainWhile = Ana program içerisindeki while döngüsünü döndürür. Yani seçenek ekranın durmadan göstermesini sağlar.

			---HESAPLAMA CLASS'IN ICERISINDEKI;
			
			string[] renklerAdi = Renkleri menüdeki gibi sıralar. Yani int[] renkler yardımıyla hangisi seçiliyse daha sonrasında
			dict mantığıyla çalışarak kullanıcıya gösterebilir. Örneğin;
			renkler[0] = 2 değerinde başka tanımlar dahilinde çıktı şu şekilde olacaktır;
			Beyaz renginden 2 adet seçilmiştir.
			
			int[] renkFiyati = Renklerin dict mantığı gibi ucretlerini gösterir.
			
			int belirtec = 0; = Kullanıcının menülerde ekleme,çıkarma veya gösterme gibi durumlarda hangi rengi seçtiğini öğrenmek
			için kullanılır.
			
			int adet = 0; = Kullanıcının seçtiği rengin kaç tane aldığını öğrenmek için kullanılır.
			
			int secenek = 0; = Kullanıcı ekleme veya çıkarma işleminden sonra ekstra olarak aynı işlemi yapmak isterse bu komut değerini
			girerek tekrarlandırmasını sağlar.
			
			string tanim = ""; = Yer kazanmak adına "Eklemek" veya "Çıkarmak" kelimesini değiştirerek program çalıştırır.
			
			bool whileDongu = true; = Kodlamanın içerisindeki birden çok while döngüsünü kontrol etmek için kullanır.
			
			bool switchDongu = true; = Kodlamanın içerisindeki birden çok switch döngüsünü kontrol etmek için kullanır.
			
				--- renkarama METODU İÇERİSİNDEKİ
				
				int toplamUcret = 0; = Kullanıcı yaptığı seçimler sonucundaki ücreti hesaplar.
				
				bool renkAlimiVar = false; = Kullanıcı renk seçimi yapıp yapmadığına bakar.
			
			---------------------------------------------HAZIRLAYAN: EMİRCAN DİZDAR---------------------------------------------		
			
			DİPNOT = Program dotnetfiddle.net üzerinden yazılmıştır. Başka programlar üzerinde düzenleme yapılması gerekebilir.
			*/

		public static void Main(string[] args)
		{

			int[] renkler = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			int mainSecim = 0;
			bool mainWhile = true;
			Hesaplama hesaplama = new Hesaplama();
			Console.WriteLine("Bu Program Renk Secmenizi Saglar.");
			hesaplama.renkAdi();
			while (mainWhile)
			{
				Console.WriteLine("\nHangi islemi yapmak istiyorsunuz: \n1-Boya Ekleme\n2-Boya Cikarma\n3-Boya Turlerini Gorme\n4-Sectiginiz Boyalar/Adetleri/Toplam Ucret,\n5-Cikis");
				mainSecim = Convert.ToInt32(Console.ReadLine());
				switch (mainSecim)
				{
					case 1:
						hesaplama.renkEkleme(renkler);
						break;
					case 2:
						hesaplama.renkCikarma(renkler);
						break;
					case 3:
						Console.Clear();
						hesaplama.renkAdi();
						break;
					case 4:
						hesaplama.renkArama(renkler);
						break;
					case 5:
						mainWhile = false;
						Console.WriteLine("Program basariyla sonlanmistir...");
						break;
					default:
						Console.WriteLine("Hatalı secim yaptiniz.");
						break;
				}
			}
		}
	}
}
