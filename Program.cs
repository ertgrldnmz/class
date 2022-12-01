internal class Program
{
    private static void Main(string[] args)
    {
        //Söz Dizimi
        //class  SinifAdi
        //{
        // [Erişim Belirleyici] [veri_tipi] ÖzellikAdı;
        // [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi[Parametre Listesi]
        //    {
        //     Metot Komutları
        //     }
        //}

        //Erişim Belirleyiciler
        //* Public
         //Private
          //internal
          //Protected

    Calisan calisan=new Calisan();
    calisan.isim="Ayşe";
    calisan.soyad="Yılmaz";
    calisan.no=1198;
    calisan.Department="İnsan Kaynakları";
    
    calisan.CalisanBilgileri();

    Console.WriteLine("******************");

    Calisan calisan2=new Calisan();
    calisan2.isim="Arda";
    calisan2.soyad="toksöz";
    calisan2.no=1562;
    calisan2.Department="Satın Alma";

    calisan2.CalisanBilgileri();
    
    
    }

    
}
class Calisan
{
    public string isim{get;set;}
    public string soyad{get;set;}
    public int no{get;set;}
    public string Department{get;set;}

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalişan Adı:{0}",isim);
        Console.WriteLine("Çalışan Soyadı:{0}",soyad);
        Console.WriteLine("Çalişan Adı:{0}",no);
        Console.WriteLine("Çalışan Soyadı:{0}",Department);

    }

}