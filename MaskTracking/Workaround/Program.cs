

using Business.Concrete;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    {

        Vatandas vatandas1 = new Vatandas();

        SelamVer("Taha");
        SelamVer("Engin");
        SelamVer("Fatma");

        Topla(40,5);

        //Diziler / Array

        string ogrenci1 = "Taha";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Yusuf";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Taha";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Yusuf";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new string[] {"Ankara","İzmir","İstanbul" };
        string[] sehirler2 = new string[] {"Erz","Ağrı","Van" };

        sehirler1 = sehirler2;
        sehirler1[0] = "Kars";
        Console.WriteLine(sehirler2[0]);

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        Person person1 = new Person();
        person1.FirstName = "Taha";
        person1.LastName = "Durdu";
        person1.TcNo = 10034258834;
        person1.DateOfBirthYear = 2001;

        
        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);

    }

    static void SelamVer(string isim = "İsimsiz")
    {
        Console.WriteLine("Merhaba" + isim);
    }
    static int Topla(int sayi1 = 10 ,int sayi2= 20)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam" + sonuc);
        return sonuc;

    }

   

}


public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}