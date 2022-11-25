// See https://aka.ms/new-console-template for more information

using ilerikalitim;
using System;

Ogrenci Ogr = new Ogrenci();
Ogr.Ad = "Ahmet";
Ogr.Soyad = "Yildiz";
Ogr.Cadde = "Rihtim Caddesi";
Ogr.Sokak = "Yeldegirmeni sokak";
Ogr.Ilce = "Kadiköy";
Ogr.Sehir = "Istanbul";
Ogr.KapiNo = 5;
Ogr.Cinsiyet = 'E';
Ogr.DogumTarihi = new DateTime(2000,02,02);
Ogr.FinalNotu = 80;
Ogr.VizeNotu = 70;
foreach (var item in Ogr.AdresAl())
{
    Console.WriteLine(item);
}

Console.WriteLine("Not Ortalaması:" + Ogr.NotHesapla());
Console.WriteLine("Yaş:" + Ogr.YasHesapla());

Console.WriteLine("----------------------------------");
Egitmen Egt = new Egitmen();
Egt.Ad = "Şamil";
Egt.Soyad = "Yilmaz";
Egt.Cadde = "Rihtim Caddesi";
Egt.Sokak = "Yeldegirmeni sokak";
Egt.Ilce = "Kadiköy";
Egt.Sehir = "Istanbul";
Egt.KapiNo = 10;
Egt.Cinsiyet = 'E';
Egt.BrutMaas = 12000;
Egt.DogumTarihi = new DateTime(1976,02,02);

//var date = new DateTime(1976,02,02);
//Egt.DogumTarihi = date;

foreach (var item in Egt.AdresAl())
{
    Console.WriteLine(item);
}

Console.WriteLine("Yaş:" + Egt.YasHesapla());
Console.WriteLine("Maaş:" +Egt.MaasHesapla());
Console.WriteLine("----------------------------------");

Calisan C = new Calisan();
C.Ad = "Asli";
C.Soyad = "Balci";
C.Cadde = "Rihtim Caddesi";
C.Sokak = "Yeldegirmeni sokak";
C.Ilce = "Kadiköy";
C.Sehir = "Istanbul";
C.KapiNo = 3;
C.Cinsiyet = 'K';
C.BrutMaas = 5500;
C.DogumTarihi = new DateTime(1989, 02, 02);
C.Departman = "IK";

foreach (var item in C.AdresAl())
{
    Console.WriteLine(item);
}
Console.WriteLine("Yaş:" + C.YasHesapla());
Console.WriteLine("Maaş:" + C.MaasHesapla());
Console.WriteLine("Departman:" + C.Departman);


