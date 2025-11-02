// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> meresek = new List<int> { 36, 48, 39, -1, 30, 43, -1, 76, 67, 82, 73, 75, 64, 73, 69, 63 };
int összeg = 0;
foreach (int adat in meresek)
{
    if (adat != -1)
        összeg += adat;
}
Console.WriteLine("2.Feladat");
Console.WriteLine($"Összesen {összeg} kerékpárost számoltak.");

Console.WriteLine("3.Feladat");
Console.WriteLine("Óránkénti mérések:");
for (int ora = 0; ora < 4; ora++)
{
    int oraiosszeg = 0;
    for (int i = ora * 4; i < ora * 4 + 4; i++)
    {
        if (meresek[i] != -1)
            oraiosszeg += meresek[i];
    }
    Console.WriteLine($"{6 + ora} órától {oraiosszeg} kerékpáros");
}
int maxErtek=int.MinValue;
int maxIndex = -1;
for (int i = 0; i < meresek.Count; i++)
{
    if (meresek[i] != -1 && meresek[i] > maxErtek)
    {
        maxErtek = meresek[i];
        maxIndex = i;
    }
}
int maxOra = 6 + (maxIndex / 4);
int maxPerc = 15 * (maxIndex % 4);
Console.WriteLine("4.Feladat");
Console.WriteLine($"Az áthaladók maximális száma: {maxErtek}; a rögzítés időpontja:{maxOra}:{maxPerc:D2}. ");