
class Progam
{
    static void Main()
    {
        int vida = 100;
        while(vida > 0)
        {
        Console.WriteLine("Digite o valor do dano: ");
        int dano = int.Parse(Console.ReadLine()!);

        vida = vida - dano;
        Console.WriteLine("Sua vida restante é: " + vida);
        
        if (vida <= 0)
        {
            Console.WriteLine("Game Over!");
            Console.Read();
        }
        }
    }
}
