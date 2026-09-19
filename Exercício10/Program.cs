
class Progam{ 
    class jogador{ 
    public string nome; 
        public int ataque = 30; 
        public int vida = 100; 
        public int defesa = 40; 
        public int nivel = 1; 
        public int xp; 
        public string[] iventario = new string[10]; 
        public int pontuação; 
        public int moedas = 200; 
} 
    class Missao{ 
        public string nome; 
        public bool concluida; 
        public int recompensa = 300; 
        public string requisitos; 

    } 
    static jogador[] jogadores = new jogador[3]; 
    static Missao[] missoes = new Missao[3]; 
    static string[] intens = ["Espada","Armadura","Escudo"]; 
    static int[] valor = [100,150,50]; 

    static int grupo; 
    static int jogadorAtual = 0; 
    static Random aleatorio = new Random(); 
    static void Main(){ 
        Console.WriteLine("==RPG de escolhas completo=="); 
        Console.WriteLine("Deseja iniciar?\n1_Sim\n2_Não"); 
        int escolha = int.Parse(Console.ReadLine()!); 
        if(escolha == 1){ 
            Console.WriteLine("Iniciando jogo >>>>>"); 
            cadastro(); 
            Console.WriteLine("Cadastro feito!!!\nQual caminho deseja seguir?"); 
            Console.WriteLine("1_Cidade\n2_Masmorra\n3_Sair"); 
            escolha = int.Parse(Console.ReadLine()!); 
            if(escolha == 1){ 
                cidade(); 

            } 
            else if(escolha == 2){ 
                Masmorra(); 
            } 
        } 
} 
    static void cadastro(){ 
        Console.WriteLine("======Cadastro de personagens======"); 
        Console.WriteLine("Determine o tamanho do grupo, maximo de 3 personagens >>>>"); 
        grupo = int.Parse(Console.ReadLine()!); 
        if(grupo > 3){ 
            grupo = 3; 
    } 
        if(grupo < 1){ 
            grupo = 1; 
        } 
        for(int i = 0; i < grupo; i++){ 
                jogadores[i] = new jogador(); 
            Console.WriteLine($"Personagem_{i + 1}\nNome:"); 
            jogadores[i].nome = Console.ReadLine()!; 
            Console.WriteLine("Ataque extra >>>>>>>"); 
            jogadores[i].ataque += int.Parse(Console.ReadLine()!); 

            Console.WriteLine("Defesa extra >>>>>>>"); 
            jogadores[i].defesa += int.Parse(Console.ReadLine()!); 
    } 
    } 
    static void loja(){ 
        jogador jogador = jogadores[jogadorAtual]; 
        Console.WriteLine("====Andarilho Comerciante====="); 
        for(int i = 0; i < intens.Length; i++){ 
            Console.WriteLine($"{i + 1}_{intens[i]} - {valor[i]} moedas"); 

        } 
        Console.WriteLine("4_Sair"); 
        Console.WriteLine($"Saldo atual: {jogador.moedas}"); 

        int escolha = int.Parse(Console.ReadLine()!); 
        if(escolha == 4){ 
            return; 
    } 

        if(escolha < 1 || escolha >3){ 
            Console.WriteLine("Item inválido!"); 
            return; 
            } 
        int item = escolha - 1; 
        if(jogador.moedas < valor[item ]){ 
            Console.WriteLine("Saldo insuficiente!"); 
            return; 


        } 
        for(int i = 0; i < jogador.iventario.Length; i++){ 
            if(jogador.iventario[i] == null){ 
                jogador.iventario[i] = intens[item]; 
                jogador.moedas -= valor[item]; 

                Console.WriteLine($"Você comprou o item: {intens[item]}"); 
                Console.WriteLine($"Saldo atual: {jogador.moedas}"); 
                return; 
        } 
        } 

    Console.WriteLine("Inventário cheio!"); 
    } 
    static void inventario(){ 
        jogador jogador = jogadores[jogadorAtual]; 
        Console.WriteLine("======Inventário======"); 

        bool vazio = true; 
        for(int i = 0; i < jogador.iventario.Length; i++){ 
            if(jogador.iventario[i] != null){ 
                Console.WriteLine($"{i + 1}_{jogador.iventario[i]}"); 
                vazio = false; 
            } 
    } 
        if(vazio){ 
            Console.WriteLine("Inventário vazio!"); 

        } 
} 
    static void cadastro_missao(){ 
        Console.WriteLine("======Cadastro de missões======"); 

        for(int i = 0; i < missoes.Length; i++){ 
            if(missoes[i] == null){ 
                missoes[i] = new Missao(); 
                Console.WriteLine($"Missão_{i + 1}"); 
                Console.WriteLine("Por favor preencha o nome da missão:"); 
                missoes[i].nome = Console.ReadLine()!; 
                Console.WriteLine("Preencha o valor da recompensa:"); 
                missoes[i].recompensa = int.Parse(Console.ReadLine()!); 
                Console.WriteLine("Digite o objetivo da missão:"); 
                missoes[i].requisitos = Console.ReadLine()!; 
                Console.WriteLine("Missão cadastrada!"); 
                return; 
                } 
    } 

            Console.WriteLine("Todas as missões já foram cadastradas!"); 
    } 
    static void mostrar_missoes(){ 
        Console.WriteLine("=======Missões======"); 
        for(int i = 0; i < missoes.Length; i++){ 
            if(missoes[i] != null){ 
                Console.WriteLine($"Missão_{i + 1}"); 
                Console.WriteLine($"Nome: {missoes[i].nome}"); 
                Console.WriteLine($"Objetivo: {missoes[i].requisitos}"); 
                Console.WriteLine($"Recompensa: {missoes[i].recompensa} moedas"); 
                Console.WriteLine($"Concluída: {missoes[i].concluida}"); 

            } 
        } 
} 

    static void turnmonstro(jogador jogador, int vidaMonstro){ 
        Console.WriteLine("Monstro atacando >>>>"); 
        int acertou = aleatorio.Next(0,10); 
        if(acertou >= 5){ 
            int dano = 20; 
            acertou = aleatorio.Next(0,10); 
            if(acertou >= 7){ 
                dano *= 2; 
                Console.WriteLine("Monstro acertou um crítico!"); 
            } 
        dano -= jogador.defesa / 10; 
            if(dano < 1){ 
                dano = 1; 
        } 
            jogador.vida -= dano; 
            Console.WriteLine($"Monstro causou {dano} de dano!"); 
            Console.WriteLine($"Vida jogador: {jogador.vida}"); 
        } 
        else{ 
            Console.WriteLine("Monstro errou!!!"); 
        } 
    } 
    static void cidade(){ 
        int escolha_cidade; 

        while(true){ 
            Console.WriteLine("Onde deseja ir?"); 
            Console.WriteLine("1_Guilda\n2_Loja\n3_Missões\n4_Sair"); 

            escolha_cidade = int.Parse(Console.ReadLine()!); 

            if(escolha_cidade == 1){ 
                Console.WriteLine("Entrando na guilda >>>>>"); 
                cadastro_missao(); 
            } 
            else if(escolha_cidade == 2){ 
                loja(); 
            } 
            else if(escolha_cidade == 3){ 
                mostrar_missoes(); 
            } 
            else if(escolha_cidade == 4){ 
                Console.WriteLine("Saindo da cidade >>>>>"); 
                return; 
            } 
            else{ 
                Console.WriteLine("Opção inválida!"); 
            } 
        } 
    } 

    static void Masmorra(){ 
        jogador jogador = jogadores[jogadorAtual]; 
        int vidaMonstro = 120; 
        Console.WriteLine("Monstro avistado!\nComeçar batalha?"); 
        Console.WriteLine("1_Sim\n2_Não"); 
        int escolha = int.Parse(Console.ReadLine()!); 

            if(escolha != 1){ 
        Console.WriteLine("Você recuou!"); 
        return; 
        } 

    while(true){ 
            Console.WriteLine("======================================"); 
            Console.WriteLine($"HP do jogador: {jogador.vida}"); 
            Console.WriteLine($"HP do Boss: {vidaMonstro}"); 
            Console.WriteLine("======================================"); 
            Console.WriteLine("========Seu turno!======="); 
            Console.WriteLine("Boss a sua frente!\nDeseja Atacar?"); 
            Console.WriteLine("1_Sim\n2_Não"); 
            escolha = int.Parse(Console.ReadLine()!); 
            if(escolha == 1){ 

                Console.WriteLine("Em batalha!\nBoa sorte..."); 
                int acertou = aleatorio.Next(0,10); 
                if(acertou >= 4){ 

                    int dano = jogador.ataque; 
                    Console.WriteLine("===Você acertou!!!==="); 
                    acertou = aleatorio.Next(0,10); 
                    if(acertou >= 7){ 
                        dano *= 2; 
                        Console.WriteLine("Acerto Crítico"); 
                } 
                    vidaMonstro -= dano; 
                Console.WriteLine($"Você causou {dano} de dano!"); 
                } 
                else{ 
                    Console.WriteLine("Você errou!"); 
                } 
            } 
        else{ 
                Console.WriteLine("Você recuou!"); 
                return; 
        } 
            if(vidaMonstro <= 0){ 
                Console.WriteLine("Você derrotou o boss!"); 
                ganhar_xp(jogador,50); 
                jogador.moedas += 100; 
                jogador.pontuação += 10; 
                Console.WriteLine("Você ganhou 50 XP!"); 
                Console.WriteLine("Você ganhou 100 moedas!"); 
                return; 

            } 
            turnmonstro(jogador,vidaMonstro); 
            if(jogador.vida <= 0){ 
                Console.WriteLine("Você perdeu!"); 
                jogador.vida = 1; 
                return; 
                } 
} 
} 

    static void ganhar_xp(jogador jogador, int quantidade){ 
        jogador.xp += quantidade; 
        Console.WriteLine($"XP: {jogador.xp}/100"); 
        if(jogador.xp >= 100){ 
            jogador.xp -= 100; 
            jogador.nivel++; 
            jogador.ataque += 10; 
            jogador.defesa += 5; 
            jogador.vida = 100; 

            Console.WriteLine("======================================"); 
            Console.WriteLine("Você subiu de nível!!!"); 
            Console.WriteLine($"Novo nível: {jogador.nivel}"); 
            Console.WriteLine($"Ataque: {jogador.ataque}"); 
            Console.WriteLine($"Defesa: {jogador.defesa}"); 
            Console.WriteLine("======================================"); 
        } 
} 
}

