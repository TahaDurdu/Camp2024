

public class Program
{
    private static void Main(string[] args)
    {

        Vatandas vatandas1 = new Vatandas();

        SelamVer("Taha");
        SelamVer("Engin");
        SelamVer("Fatma");

        Topla(40,5);

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