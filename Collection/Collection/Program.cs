using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
	class Program
	{
		static void Main(string[] args)
		{
			// Array => Fixed size sabit bir kapasiteye sahiptir.

			// Collection // daha fazla kapasiteye sahiptir.
			// ** non-generic tipler vardır bunun içerisine ArrayList ,SortedList atabilirsiniz.
			// ** generic tipler olarak atama yaptığımızda tanımladığımız collectiona göre atamalar yapabiliriz int ise int string ise string tip atamalar yapabiliriz..
			// ** generic  => List <int> sadece int olarak atamalar yapılabilir.



			ArrayList myList = new ArrayList();

			myList.Add(5);    // index numarasıdı 0 dan başlar
			myList.Add("10"); // 1.İndex
			myList.Add(10.5); //2.İndex
			myList.GetEnumerator(); //3.İndex

			IList myList2 = new ArrayList() {"**********",10,"10","abc",10.5 };

			// Accessing Item

			//Console.WriteLine(myList[0]);
			//int sayi = (int)myList[0];  // Tür dönüşümü yapılmasındaki olanak sağlayan object olarak tanınması ve biz bunu string olarakda yapabiliriz.
			//Insert metodu ile bir eleman ekleyebilir ve istediğimiz index numarasını verebiliriz
			// Add metodu ise listenin en sonuna eklenir liste dinamik olduğu için kapasitesi artabiliyor.

			//myList.Insert(0, "4");

			//myList.InsertRange(4, myList2); // Myliste arrayin içerisine farklı bir array listesi eklettirdik index ve arrayi belirterek bu işlemi gerçekleştiriyoruz.


			// eleman silemk istersek 
			// REMOVE ITEMS


			//myList.RemoveAt(0); // İndex numarasına göre bir silme işlemi gerçekleştirir
			//myList.Remove(10.5); // içeride olan string yada int veri tipinin içerisindeki değeri silebilirsiniz yukarıda tanımladıgım 10.5 add ile ekledik remove ilede silme işlemi gerçekleştirdik.
			//myList.RemoveRange(0, 2); // burada birden fazla index numarasını silmek istersek eğer removerange  metodu 0 dan başlar 2.indexe kadar listedeki verileri siler.
			//foreach(object a in myList)
			//{
			//	Console.WriteLine(a);
			//	Console.ReadLine();
			//}

			Console.WriteLine(myList.Contains(10)); // Contains bize true yada false döndürür içerisinde 10 değeri varmı yokmu diye  konsola true yada false döndürür.


			ArrayList sayilar = new ArrayList() { 10, 2134, 455, 123456, 12312214, 213211, };


			foreach (var item in sayilar)
			{
				Console.WriteLine(item);
			}

			sayilar.Sort(); // iki kere ekrana yazdırma işlemi yaptık burada bunu yapmamızın sebebi Sort Metodunun küçükten büyüğe sıralamasındaki sıralamayı gözlemlemek.
			// ArrayListin hepsi eğer string bir ifade ise bu sefer alfabetik bir sıralama yapılır.

			foreach (var item in sayilar)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
				


 		}
	}
}
