// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

Console.Title = "Hesap Makinesi V-1.0";
Console.WriteLine("1. Toplama");
Console.WriteLine("2. Cikarma");
Console.WriteLine("3. Carpma");
Console.WriteLine("4. Bolme");
Console.WriteLine("5. Cikis");
Console.Write("Lutfen Bir Secim Yapin : ");
var secim = Console.ReadLine();
int operant1 = 0;
int operant2 = 0;

switch (secim)
{

    case "1":
        Sayilar();
        Console.WriteLine("Sayilarin Toplami : " +(operant1+operant2));
        Cikis();
        break;
    case "2":
        Sayilar();
        Console.WriteLine("Sayilarin Farki : " + (operant1 - operant2));
        Cikis();
        break;
    case "3":
        Sayilar();
        Console.WriteLine("Sayilarin Carpimi : " + (operant1 * operant2));
        Cikis();
        break;
    case "4":
        Sayilar();  
        float cevap = (float)operant1/(float)operant2;
        Console.WriteLine("Sayilarin Bolumu : " + (cevap));
        Cikis();
        break;
    case "5":
        Console.Write("Cikis Yapildi");
        Console.ReadLine();
        break;
    default:
        Console.WriteLine("Yanlis Bir Secim Yaptiniz");
        Cikis();
        break;
}
static void Cikis()
{

    Console.WriteLine("Yeni bir işlem yapmak ister misiniz? (e/h)");
    var cevap = Console.ReadLine();
    if (cevap == "e")
    {
        Console.Clear();
        Process.Start("Odev 2", "");
    }
    else if (cevap == "h")
    {
        Console.Write("Cikis Yapildi");
    }
    else
    {
        Console.Write("Yanlis Girdi. Cikis Yapildi");
    }
}
void Sayilar()
{
    Console.Write("1. operanti girin : ");
    operant1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. operanti girin : ");
    operant2 = Convert.ToInt32(Console.ReadLine());
}


