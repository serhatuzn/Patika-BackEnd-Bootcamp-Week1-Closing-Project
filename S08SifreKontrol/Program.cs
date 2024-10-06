string sifre = "12345";

Console.Write("Lütfen Şifrenizi Giriniz: ");
string girilensifre = Console.ReadLine();

if(girilensifre == sifre)
{
    Console.WriteLine("Giriş başarılı");
}
else
{
    Console.WriteLine("Giriş Başarısız.");
}

