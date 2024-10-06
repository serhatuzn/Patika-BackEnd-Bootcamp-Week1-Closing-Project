Console.Write("Lütfen 1 ile 7 arasında bir sayı giriniz: ");
string cevap = Console.ReadLine();
int gunSayisi = Convert.ToInt32(cevap);
int gun;

switch (gunSayisi)
{
    case 1:
        gun = 1;
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        gun = 2;
        Console.WriteLine("Salı");
        break;
    case 3:
        gun = 3;
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        gun = 4;
        Console.WriteLine("Perşembe");
        break;
    case 5:
        gun = 5;
        Console.WriteLine("Cuma");
        break;
    case 6:
        gun = 6;
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        gun = 7;
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Hatalı giriş yaptınız.");
        break;
}
