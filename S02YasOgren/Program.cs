Console.Write("Yasinizi giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());

if (yas >= 18)
{
    Console.WriteLine("Yetişkinsiniz.");
}
else
{
    Console.WriteLine("Çocuksunuz.");
}