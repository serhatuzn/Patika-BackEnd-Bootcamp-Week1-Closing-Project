Console.Write("Lütfen bir sıcaklık giriniz: ");
int sicaklik = Convert.ToInt32(Console.ReadLine());

if (sicaklik > 30)
{
    Console.WriteLine("Hava sıcak.");
}
else if (sicaklik < 0)
{
    Console.WriteLine("Hava soğuk.");
}
else
{
    Console.WriteLine("Hava normal.");
}
