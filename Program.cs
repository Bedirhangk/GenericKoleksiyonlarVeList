namespace GenericKoleksiyonlarVeList;

using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //List<t> class
        //system.collections.Generic
        //T-> Object Türündedir.

        List<int> sayilistesi=new List<int>();
        sayilistesi.Add(36);
        sayilistesi.Add(96);
        sayilistesi.Add(312);
        sayilistesi.Add(3);
        sayilistesi.Add(6);
        sayilistesi.Add(12);
        sayilistesi.Add(21);

        List<string> renk=new List<string>();
        renk.Add("Mavi");
        renk.Add("Sarı");
        renk.Add("Beyaz");
        renk.Add("Kırmızı");
        renk.Add("Siyah");
        renk.Add("Mor");

        //count
        Console.WriteLine("----------List Count------------");
        Console.WriteLine(renk.Count);
        Console.WriteLine(sayilistesi.Count);
        Console.WriteLine("");

        //Foreach ve list.foreach ile liste elemanlarına erişim

        Console.WriteLine("---------------Foreach--------------");
        Console.WriteLine("");

        foreach(var s in sayilistesi)
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("");

        foreach (var r in renk)
        {
            Console.WriteLine(r);
        }

        Console.WriteLine("");

        Console.WriteLine("------------List.foreach--------------");

        Console.WriteLine("");

        sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
        Console.WriteLine("");
        renk.ForEach(rnk=> Console.WriteLine(rnk));

        Console.WriteLine("");

        //Listeden Eleman Çıkarma

        Console.WriteLine("------------Listeden Eleman Çıkarma-------------");
        Console.WriteLine("");

        sayilistesi.Remove(3);
        renk.Remove("Mor");

        sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
        Console.WriteLine("");
        renk.ForEach(rnk=> Console.WriteLine(rnk));

        //Yukarıdaki işlem İndex ile yapmak için
        Console.WriteLine("-----------İndex ile Eleman Çıkarma---------------");
        Console.WriteLine("");

        sayilistesi.RemoveAt(0);
        renk.RemoveAt(1);

        sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));
        Console.WriteLine("");
        renk.ForEach(rnk=> Console.WriteLine(rnk));        
        Console.WriteLine("");

        //Liste İçerisnde Arama
        if(sayilistesi.Contains(6))
            Console.WriteLine("Liste içinde Bulundu.");
        
        //Eleman ile index bulma
        Console.WriteLine(renk.BinarySearch("Mavi"));
        Console.WriteLine(sayilistesi.BinarySearch(12));
        
        //Diziyi liste yapma
        string [] hayvanlar={"kedi", "köpek", "kuş", "sincap"};

        List <string> hayvanlarlistesi=new List<string>(hayvanlar);

        //Listeyi nasıl temizlenir.
        hayvanlarlistesi.Clear();

        //Liste İçerisnde nesne tutmak istersek        
        List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
        Kullanıcılar kullanıcı1 = new Kullanıcılar();
        kullanıcı1.Isim ="Bedirhan";
        kullanıcı1.Soyisim="Gökkaya";
        kullanıcı1.Yas=21;

        Kullanıcılar kullanıcı2 = new Kullanıcılar();
        kullanıcı2.Isim ="Umut Yasin";
        kullanıcı2.Soyisim="Gürtürk";
        kullanıcı2.Yas=16;

        kullanıcıListesi.Add(kullanıcı1);
        kullanıcıListesi.Add(kullanıcı2);

        List<Kullanıcılar> YeniListe =new List<Kullanıcılar>();

        YeniListe.Add(new Kullanıcılar(){
            Isim="Esra",
            Soyisim="Serçe",
            Yas=26
        });

        Console.WriteLine("");

        foreach(var k in kullanıcıListesi)
        {
            Console.WriteLine("İsim: "+k.Isim);
            Console.WriteLine("Soyisim: "+k.Soyisim);
            Console.WriteLine("Yaş: "+k.Yas);
            Console.WriteLine("");
        }
    }
}

public class Kullanıcılar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim {get=> isim; set=>isim=value;}
    public string Soyisim {get=>soyisim; set=>soyisim=value;}
    public int Yas {get=>yas; set=>yas=value;}
}

