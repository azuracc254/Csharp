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
    static Random rnd = new Random();

    static void Main()
    {
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

    else
    {
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
        Console.WriteLine("Você derrotou o monstro, sua vida recuperada!");

        if (XP >= XP_maximo){
            nivel += 1;
            XP_maximo *= nivel / 10f;
            XP = 0;
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

        Console.WriteLine($"Você errou!\nSua vida: {vida}\nDeseja continuar?");
        escolha2 = int.Parse(Console.ReadLine()!);
        if (escolha2 == 1){
        Console.WriteLine("Ótima escolha!");
        escolha2 = 0;
        inimigo();
        }
         else{
        Console.WriteLine("Fim de jogo!");
        escolha = 0;
        }
    }
}
}

    