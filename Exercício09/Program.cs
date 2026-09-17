class Progam{
    static int[] ranking = new int[10];
    static int[] top3 = new int[3];
    static void Main()
    {
    listando();
    } 
    static void listando(){
        for(int i = 0; i < 10; i ++){
            Console.WriteLine("Ranqueando as pontuações!!!");
            Console.WriteLine($"Digite a posição: {i + 1}");
            int temp = int.Parse(Console.ReadLine()!);
        }
        Array.Sort(listando);
        Console.WriteLine("Determinando o ranking.........");
        for(int i = 0; i < 10; i ++){
            Console.WriteLine($"Posição_{i + 1} {ranking[i]}");
        }
        Console.WriteLine("Top 3:");
        for(int i = 0; i < 4; i ++){
            Console.WriteLine($"Posição_{i + 1}: {ranking[i]}");
        }
    }
}