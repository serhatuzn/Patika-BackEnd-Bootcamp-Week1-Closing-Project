Console.Write("Lütfen Notunuz girin: ");
int not = Convert.ToInt32(Console.ReadLine());

if (not < 0 || not > 100)
{
    Console.WriteLine("Girdiğiniz puan geçersiz.");
    return;
}

if (not > 80)
{
    Console.WriteLine("Başarılı. ");
}
else if (not < 60)
{
    Console.WriteLine("Başarsız. ");
}

else 
{
    Console.WriteLine("Orta");
}