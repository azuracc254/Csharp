
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
        public int moedas;
    }
    class Missao{
        public  string nome;
        public  bool concluida;
        public  int recompensa = 300;
        public string requisitos;
    }
    jogador primeiro = new jogador();
    jogador segundo = new jogador();
    jogador terceiro = new jogador();

    public jogador[] jogadores = [primeiro(), segundo(), terceiro()];
    static string[] intens = ["Espada","Armadura","Escudo"];
    static int[] valor = [100, 150, 50];

       static void Mian(){
        Console.WriteLine("==RPG de escolhas completo==");
        Console.WriteLine("Deseja iniciar?\n1_Sim\n1_Não");
        int escolha = int.Parse(Console.ReadLine);
        if(escolha == 1){
            Console.WriteLine("Iniciando jogo >>>>>");
            cadastro();
            Console.WriteLine("Cadastro feito!!!\nQual caminho deseja seguir?");
            Console.WriteLine("1_Cidade\n2_Masmorra\nAndarilho comerciante");
            escolha = int.Parse(Console.ReadLine());
            if(escolha == 1){
                Console.WriteLine("Entrando na cidade >>>>>>>> ");
            }
        }
    }
        static void cadastro(){
        Console.WriteLine("======Cadastro de personagens======");
        Console.WriteLine("Determine o tamanho do grupo, maximo de 3 personagens >>>>");
        grupo = int.Parse(Console.ReadLine()!);
        grupo = Math.Min(3);
        for(int i; i <= grupo; i ++){
        Console.WriteLine($"Personagem_{i}\nNome:");
        jogadores[i].nome = Console.ReadLine();
        Console.WriteLine("Ataque extra >>>>>>>");
        jogadores[i].ataque += int.Parse(Console.ReadLine());
        Console.WriteLine("Defesa extra >>>>>>>");
        jogadores[i].defesa += int.Parse(Console.ReadLine());
        }
    static void loja(){
        Console.WriteLine("====Andarilho Comerciante====");
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
    static void turnmonstro(){
    Console.WriteLine("Monstro atacando >>>>");
    Random acerto = new Random();
    int acertou = acerto.Next(0, 10);
    if(acertou >= 5){
        acertou = acerto.Next(0, 10);
        if(acertou >= 7){
            vidaJogador -= 15 * 2;
        Console.WriteLine($"Monstro acertou um crítico!\nVida jogador: {vidaMonstro}");
        }
        else{
        Console.WriteLine($"Monstro acertou\nVida do jogador: {vidaJogador}");
        }
        }
        else{
        Console.WriteLine("Monstro errou!!!");
        }
        }
    static void cidade(){
    int escolha_cidade;
    Console.WriteLine("Onde deseja ir?");
    Console.WriteLine("1_Guilda\n1_Saida");
        if(escolha_cidade == 1){
            Console.WriteLine("Entrando na guilda >>>>>");
            Console.WriteLine("Iniciando cadastro de missões >>>>>");
            cadastro_missao();
        }
        else {
            Console.WriteLine("Saindo da cidade >>>>>");
            Console.WriteLine("1_Cidade\n2_Masmorra\nAndarilho comerciante");
        }
    }
    static void Masmorra(){
        Console.WriteLine("Monstro avistado!\nComeçar batalha?");
        escolha = int.Parse(Console.ReadLine());
        if(escolha == 1){
            foreach(jogador temp in jogador){
            if(jogador.vida <= 0)
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
        }
    }
}
}
