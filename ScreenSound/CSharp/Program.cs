// Screen Sound

//List<String> bandas = new List<string>();
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("RBD", new List<int> { 10, 8, 9});
bandas.Add("One Direction", new List<int>());

void ExibirMensagem()
{
    Console.WriteLine(@"
SCREEN SOUND
");
    string mensagem = "Boas vindas!";
    Console.WriteLine(mensagem);
}

void ExibirOpcoes()
{
    ExibirMensagem();

    Console.WriteLine("\nDigite 1 para registrar uma banda\nDigite 2 para mostrar todas as bandas\nDigite 3 para avaliar uma banda\nDigite 4 para exibir a media de uma banda\nDigite 0 para sair ");
    Console.WriteLine("\nDigite sua opção:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumero = int.Parse(opcaoEscolhida);
    
    switch (opcaoNumero)
    {
        case 1: RegistrarBandas(); 
            break;
        case 2: MostrarBandas();
            break;
        case 3: AvaliaBanda();
            break;
        case 4: MediaBanda();
            break;
        case 0:
            Console.WriteLine("Fechando programa");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTitulo("Registro de Bandas");
    Console.WriteLine("Digite o nome da banda: ");
    string nome = Console.ReadLine()!;
    //bandas.Add(nome);
    bandas.Add(nome, new List<int>());
    Console.WriteLine($"A banda {nome} foi registrada!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpcoes();

}       

void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Bandas registradas");
    //for (int i = 0; i < bandas.Count; i++)
    //{
    //    Console.WriteLine(bandas[i]);
    //}

    foreach (string item in bandas.Keys)
    {
        Console.WriteLine(item);
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoes();

    
}

void AvaliaBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar Banda");

    Console.WriteLine("Digite o nome da banda que quer avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual nota a banda {nomeBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada para a banda {nomeBanda}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoes();

    } else 
    { 
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!\n Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoes();
    }
}

void MediaBanda()
{
    Console.Clear();
    ExibirTitulo("Exibir média da banda");

    Console.WriteLine("Digite o nome da banda que quer consultar a média: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        List<int> mediaBanda = bandas[nomeBanda];
        Console.WriteLine($"A média da banda {nomeBanda} é: {mediaBanda.Average()}");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoes();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!\n Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoes();
    }
}

void ExibirTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoes();