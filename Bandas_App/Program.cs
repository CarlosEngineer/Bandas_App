//Screen Sound 

String mensagemBoasVindas = "Seja bem vindo ao Screen Sound!";
//List<string> ListaDasBandas = new List<string> { "iron maiden", "U2", "FooFigther"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10,8});
bandasRegistradas.Add("Bon jovi", new List<int>());

void ExibirLogo()
{                       // recurso com @ é chamado de verbatim literal.
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░   
");

    Console.WriteLine(mensagemBoasVindas);

}



void ExibirOpcoesMenu()
{
    ExibirLogo();
    ExibirTituloOpcoes("Menu do aplicativo \n");
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar  todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a media de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite sua opcao:");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
 
    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Voce escolheu a opcao: " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Voce escolheu a opcao: " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Voce escolheu a opcao :) " + opcaoEscolhidaNumerica);
            break;
        default:
            Console.WriteLine("Opcao Invalida " + opcaoEscolhidaNumerica);
            break;
    }
}




void RegistrarBandas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloOpcoes("\nRegistros das bandas\n");
    Console.Write("Digite o nome da banda, que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());    
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}



void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirLogo();
    ExibirTituloOpcoes("Registro de todas as bandas");
    

    /* for (int i = 0; i < ListaDasBandas.Count; i++)
     {
         Console.WriteLine($"Banda {ListaDasBandas[i]}");
     }
    */
    {
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }



        Console.WriteLine("\nDigite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }

}




    void ExibirTituloOpcoes( string titulo)
    {
        int qtdLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos );
    }


    ExibirOpcoesMenu();

