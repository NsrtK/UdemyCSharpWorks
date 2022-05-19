// See https://aka.ms/new-console-template for more information

int sayi1, sayi2;
Console.WriteLine("1.sayıyı giriniz:");
sayi1 = int.Parse(Console.ReadLine());
Console.WriteLine("2.sayıyı giriniz:");
sayi2 = int.Parse(Console.ReadLine());
int sayi1BolenToplam = 0;
int sayi2BolenToplam = 0;

for (int i = 1; i < sayi1; i++)
{
    if (sayi1 % i == 0)
    {
        sayi1BolenToplam += i;
    }
    
}
for (int i = 1; i < sayi2; i++)
{
    if (sayi2 % i == 0)
    {
        sayi2BolenToplam +=  i;
    } 
}
Console.WriteLine(sayi1BolenToplam);
Console.WriteLine(sayi2BolenToplam);

if (sayi1BolenToplam == sayi2 || sayi2BolenToplam==sayi1)
{
    Console.WriteLine("Sayılar arkadaş sayıdırlar!");
}
else
{
    Console.WriteLine("Sayılar arkadaş sayı değildir!");
}
