using System;
using System;
class Progam
{
    static int dano = 20;
    static int vida = 100;
    static int vida_maxima = 100;
    static int nivel = 1;
    static int XP = 0;
    static float XP_maximo = 100f;
    static int inimigos_derrotados = 0;
    static int escolha;
    static int escolha2;
    static string[] inventario = [" ", " ", " ", " ", " "];
    static string[] possiveis_itens = ["Espada","Escudo","Arco","Poção","Flechas"];
    static Random rnd = new Random();

    static void Main(){
    Console.WriteLine("Deseja começar o jogo?");
    Console.WriteLine("1: Sim\n2: Não");
    escolha = int.Parse(Console.ReadLine()!);
    if(escolha == 1){
        Console.WriteLine("Boa escolha");
        while (escolha == 1)
    {
    Console.WriteLine("Inimigo avistado");
    Console.WriteLine("Deseja lutar? ");
    escolha2 = int.Parse(Console.ReadLine()!);
    if(escolha2 == 1){
        escolha2 = 0;
        Console.WriteLine("Em batalha!");
        inimigo();
    }

    else{
        escolha2 = 0;
        Console.WriteLine("Você escolheu recuar!\nCovarde!");
        Console.WriteLine("Deseja continuar?");
        escolha2 = int.Parse(Console.ReadLine()!);
    if (escolha2 == 1){
        Console.WriteLine("Fim de jogo!");
        Console.WriteLine($"Vida: {vida}\nNível: {nivel}\nInimigos derrotados: {inimigos_derrotados}");
        escolha = 0;
        }
    }
    }
    }

    else{
        Console.WriteLine("Decepcionante!\nFim de jogo!");
        Console.WriteLine($"Vida: {vida}\nXP: {XP}\nNível: {nivel}\nInimigos derrotados: {inimigos_derrotados}");
    }
    }

    static void inimigo()
    {
        int acertou = 0;
        Random acerto = new Random();
        acertou = acerto.Next(0, 20);
        if (acertou >= 8){
        inimigos_derrotados += 1;
        vida = vida_maxima;
        XP += 30;
        Console.WriteLine("====Você derrotou o monstro, sua vida recuperada!====");
        Random_intem();

        if (XP >= XP_maximo){
            nivel += 1;
            XP_maximo *= nivel;
            XP = 0;
            vida_maxima += 20;
                Console.WriteLine($"Você subiu de nível!\nXP atual: {XP}\nXP requisitado: {XP_maximo}");
            }
        }
        else{
        if (nivel < 2){
            vida -= dano;
        }

        else{
        vida -= Math.Abs(dano * nivel / 2);
        }

        Console.WriteLine($"====Você errou!====\nSua vida: {vida}\nDeseja continuar?");
        escolha2 = int.Parse(Console.ReadLine()!);
        if (escolha2 == 1){
        Console.WriteLine("====Ótima escolha!====");
        escolha2 = 0;
        inimigo();
        }

         else{
        Console.WriteLine("====Fim de jogo!====");
        escolha = 0;
        }
    }
    static void Random_intem()
        {
        Random item = new Random();
        int local = item.Next(0, 10);
        if(local >= 8){
            Console.WriteLine("====Você ganhou um item!====");

            local = item.Next(0, 4);
            string str = possiveis_itens[local];
            Console.WriteLine($"Você ganhou um(a) {str}!");
            Console.WriteLine($"Seu inventario pussui {inventario.Length} slots\n Onde desejas preencher?");
            Console.WriteLine("Slot_0:\nSlot_1:\nSlot_2:\nSlot_3\nSlot_4:");

            inventario[int.Parse(Console.ReadLine()!)] = possiveis_itens[local];

            foreach(string i in inventario){
                  Console.WriteLine(i);
                }
        }
        else{
            Console.WriteLine("Você ganhou nada...");
            Console.WriteLine("Seu inventario:");
            foreach(string i in inventario){
                int contador = 1;
                Console.WriteLine($"Slot {contador}: {i}");
                contador ++;
                }
        }
        }
}
}

