using System;
class Progam
{
    static int vidaJogador = 100;
    static int vidaMonstro = 80;
    static bool continua = true;
    static void Main()
    {
        while(continua){
            turnoJogador();
            turnmonstro();
        }
        static void turnoJogador(){
            if(vidaJogador <= 0)
            {
                Console.WriteLine("Você perdeu!");
                Console.WriteLine($"HP do Boss: {vidaMonstro}");
                continua = false;
            }
            if(vidaMonstro <= 0){
                Console.WriteLine("Você derrotou o boss!");
                Console.WriteLine($"HP do jogador: {vidaJogador}");
                continua = false;
            }
            Console.WriteLine("========Seu turno!=======");
            Console.WriteLine("Boss a sua frente!\nDeseja Atacar?");
            Console.WriteLine("1_Sim\n1_Não");
            int escolha = int.Parse(Console.ReadLine()!);
            if(escolha == 1){
                Console.WriteLine("Em batalha!\nBoa sorte...");
                Random acerto = new Random();
                int acertou = acerto.Next(0, 10);
                if(acertou >= 4){
                    Console.WriteLine("===Você acertou!!!===");
                    acertou = acerto.Next(0, 10);
                    if(acertou >= 7){
                        vidaMonstro -= 10 * 2;
                        Console.WriteLine("Acerto Crítico");
                    }
                    else{
                        vidaMonstro -= 10;
                    }
                }
            else{
                Console.WriteLine("Você errou!");
                Console.WriteLine($"HP do jogador: {vidaJogador}\nHP do Boss: {vidaMonstro}");
                Console.WriteLine("======================================");
            }
            }
            else{
                Console.WriteLine("Você recuou!");
                Console.WriteLine("Pssando o turno!");
                Console.WriteLine("=====================================");
            }
        }
        static void turnmonstro(){
            Console.WriteLine("Boss atacando!!!");
            Random acerto = new Random();
            int acertou = acerto.Next(0, 10);
            if(acertou >= 5){
                acertou = acerto.Next(0, 10);
                if(acertou >= 7){
                    vidaJogador -= 15 * 2;
                    Console.WriteLine($"Boss acertou um crítico!\nVida jogador: {vidaMonstro}");
                }
                else{
                    Console.WriteLine($"Boss acertou\nVida do jogador: {vidaJogador}");
                }
            }
            else{
                Console.WriteLine("Boss errou!!!");
            }
        }
    }
}
