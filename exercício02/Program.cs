
class Progam
{
    static void Main()
    {
        int moedas = 0;
        int coletados = 0;
        while(coletados <= 10 && moedas <= 99)
        {
            Console.WriteLine("Moedas coletadas >>>> ");
            moedas += int.Parse(Console.ReadLine()!);
            coletados ++;
            if(moedas > 99)
            {
            Console.WriteLine("Parabéns! Você conseguio uma vida extra!");
            }
        }
    }

}
