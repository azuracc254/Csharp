using System;
class Progam
{
    static int moedas;
    static string[] intens = ["Espada","Armadura","Escudo"];
    static int[] valor = [100, 150, 50];
    static void Main()
    {
        loja();
    }
    static void loja(){
        Console.WriteLine("====Loja de itens====");
        foreach (string str in intens)
        {
            int contador = 0;
            Console.WriteLine($"{str} " + $"{valor[contador]}");
            contador ++;            
        }
        Console.WriteLine("Deseja comprar alguma coisa?");
        Console.WriteLine("1_Sim\n2_Não");
        int escolha = int.Parse(Console.ReadLine()!);
        if(escolha == 1){
            Console.WriteLine("Digite seu saldo: ");
            moedas = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Qual item deseja comprar?");
            Console.WriteLine("1_Espada\n2_Armadura\n3_Escudo");
            escolha = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Você escolheu: {intens[escolha]}");
            if(moedas < valor[escolha]){
                Console.WriteLine("Saldo insuficiente!");
                Console.WriteLine("Escolha outra coisa!");
                loja();
            }
            else{
                Console.WriteLine($"Você comprou o item: {intens[escolha]}");
                moedas -= valor[escolha];
                Console.WriteLine($"Saldo atual: {moedas}");
            }
        }
        else{
            Console.WriteLine("QUe pena!\nAté a próxima!");
        }
    }
}
