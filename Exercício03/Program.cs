
using System;
using System.Linq;
class Progam
{
    static void Main()
    {
    Random rnd = new Random();
    int dano = 0;
    int aumenta = 0;
    int dano_critico;
    Console.WriteLine("Dano base >>>>>>> ");
    dano = int.Parse(Console.ReadLine()!);
    aumenta = rnd.Next(0, 100);
    if (aumenta >= 80)
    {
    dano_critico = dano * 2; 
    Console.WriteLine($"Dano base: {dano}\n Círitico!\n Dano causado: {dano_critico}");
    }
    else
    {
        Console.WriteLine($"Dano causado: {dano}");    
    }
    }
}
