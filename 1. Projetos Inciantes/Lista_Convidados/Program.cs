Console.WriteLine("Escolha uma das opções abaixo");
string opcao;
List<string> convidados = [];

do{
  Console.Clear();
  Console.WriteLine("1. Adicionar Convidado\n 2. Remover nome\n 3. Listar todos\n 4. Sair do programa");
  opcao = Console.ReadLine()!;

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Digite o nome do convidado: ");
      string? nomeConvidado = Console.ReadLine();
      convidados.Add(nomeConvidado!);
      break;
    case "2":
      Console.WriteLine("Digite o nome do convidado que quer remover: ");
      string? nomeConvidadoRemocao = Console.ReadLine();
      convidados.Remove(nomeConvidadoRemocao!);
      break;
    case "3":
      Console.WriteLine("Todos os convidados");
      foreach (string convidado in convidados)
      {
        Console.WriteLine(convidado);
      }
      Console.ReadKey();
      break;
    case "4":
      Console.WriteLine("Saindo... ");
      break;
    default:
      Console.WriteLine("Nenhuma opção marcada");
      break;
  }
} while (opcao != "4");

