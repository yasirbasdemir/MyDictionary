using System;

namespace MyDictionary
{
   // ÖDEV KONUSU  :
   // Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary)
   // Sadece ekleme(Add) metodunu yazınız.
   // Yazdığınız kodu GitHub sayfanızı atıp yorum kısmına adresini ekleyiniz.
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> fullName = new MyDictionary<string>();
            fullName.Add("Yasir Başdemir");
            fullName.Add("Murat Başdemir");
            fullName.Add("Muhammed Hasan Başdemir");
            Console.WriteLine(fullName.Count);
        }
    }
}
