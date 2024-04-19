Random random = new Random();
int rasgele = random.Next(0, 100);
int başlangıç = 0;

while (başlangıç != rasgele) 
{
    Console.Write("Rasgele sayı giriniz: ");
    int sayı = Convert.ToInt32(Console.ReadLine());
    if (sayı > rasgele)
    {
        Console.WriteLine("daha düşük bir sayı girin");
        
    }
    else if (sayı < rasgele)
    {
        Console.WriteLine("daha büyük bir sayı girin");
        
    }
    else if (sayı == rasgele)
    {
        break;
    }
}
Console.WriteLine("doğru bildin");
