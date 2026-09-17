using System;
using System.Security.Cryptography.X509Certificates;
class Progam
{
    static int vidaJogador = 100;
    static int vidaMonstro = 80;
    static bool continua = true;
    static int contador = 0;
    class Missao{
        public  string nome;
        public  bool concluida;
        public  int recompensa;
        public string requisitos;
    }
    static Missao missao1 = new Missao();
    static Missao missao2 = new Missao();
    static Missao missao3 = new Missao();

    static void Main(){

        Console.WriteLine("RPG do pedro >>>>>>>>>>>>>>>");
        Console.WriteLine("Deseja Começar o jogo?");
        Console.WriteLine("1_Sim\n2_Não");
        int escolha = int.Parse(Console.ReadLine()!);
        if (escolha == 1){
            Console.WriteLine("Boa escolha!\nDeseja cadastrar suas missões?");
            escolha = int.Parse(Console.ReadLine()!);
            if(escolha == 1){
                cadastro_missao();
                Console.WriteLine("Missões cadastradas com sucesso!");
                Console.WriteLine("Deseja começar as missões?");
                escolha = int.Parse(Console.ReadLine()!);
                if(escolha ==1){
                    Console.WriteLine("Missões iniciadas...");
                    Console.WriteLine("Missão_1 concluida?");
                    escolha = int.Parse(Console.ReadLine()!);
                    if(escolha == 1){
                        missao1.concluida = true;
                    }
                    else{
                        missao1.concluida = false;
                    }
                    Console.WriteLine("Missão_2 concluida?");
                    escolha = int.Parse(Console.ReadLine()!);
                    if(escolha == 1){
                        missao2.concluida = true;
                    }
                    else{
                        missao2.concluida = false;
                    }
                    Console.WriteLine("Missão_3 concluida?");
                    escolha = int.Parse(Console.ReadLine()!);
                    if(escolha == 1){
                        missao3.concluida = true;
                    }
                    else{
                        missao3.concluida = false;
                    }
            }
            else{
            Console.WriteLine("Que pena!");
            }
        }
        else{
            Console.WriteLine("Até a próssima...");
        }
        if(missao1.concluida == true){
            Console.WriteLine($"Missão {missao1.nome}: Concluida");
        }
        else Console.WriteLine($"Missão {missao1.nome}: Pendente");
        if(missao2.concluida == true){
            Console.WriteLine($"Missão {missao2.nome}: Concluida");
        }
        else Console.WriteLine($"Missão {missao2.nome}: Pendente");
        if(missao3.concluida == true){
            Console.WriteLine($"Missão {missao3.nome}: Concluida");
        }
        else Console.WriteLine($"Missão {missao3.nome}: Pendente");
    }
     
    static void cadastro_missao(){
        Console.WriteLine("Missão_1");
        Console.WriteLine("Purvafor preencha o nome da missão: ");
        missao1.nome = Console.ReadLine()!;
        Console.WriteLine("Preencha o valor da recompensa: ");
        missao1.recompensa = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o objetivo da missão: ");
        missao1.requisitos = Console.ReadLine()!;
        Console.WriteLine("==========================================");
        Console.WriteLine("Missão_2");
        Console.WriteLine("Purvafor preencha o nome da missão: ");
        missao2.nome = Console.ReadLine()!;
        Console.WriteLine("Preencha o valor da recompensa: ");
        missao2.recompensa = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o objetivo da missão: ");
        missao2.requisitos = Console.ReadLine()!;
        Console.WriteLine("==========================================");
        Console.WriteLine("Missão_1");
        Console.WriteLine("Purvafor preencha o nome da missão: ");
        missao3.nome = Console.ReadLine()!;
        Console.WriteLine("Preencha o valor da recompensa: ");
        missao3.recompensa = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o objetivo da missão: ");
        missao3.requisitos = Console.ReadLine()!;
        Console.WriteLine("===========================================");
    }
        
}
}
