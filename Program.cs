//screen sound


String mensagem = "boas vindas ao screen sound";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
        
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
        ");
    Console.WriteLine(mensagem);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opcao: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) 
    {
        case 1: Console.WriteLine("voce escolheu a opcao " + opcaoEscolhidaNumerica);
            break; 
        case 2: Console.WriteLine("voce escolheu a opcao " + opcaoEscolhidaNumerica);
                break;
        case 3: Console.WriteLine("voce escolheu a opcao " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("voce escolheu a opcao " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("voce escolheu a opcao " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opcao invalida");
            break;
    } 

}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();





