Console.WriteLine("Bem vindo à Calculadora!");

Console.WriteLine("Digite o primeiro número:");
string? numero1 = Console.ReadLine();

Console.WriteLine("Digite o segundo número:");
string? numero2 = Console.ReadLine();

Console.WriteLine("Qual operação vai ser ?\n + -> Soma\n - -> Diferença\n * -> Multiplicação\n / -> Divisão");
string? opção = Console.ReadLine();

double resultado = 0;

switch(opção)
{
  case "+":
    resultado = double.Parse(numero1) + double.Parse(numero2);
    Console.WriteLine($"Resultado é {resultado}");
    break;
  case "-":
    resultado = double.Parse(numero1) - double.Parse(numero2);
    Console.WriteLine($"Resultado é {resultado}");
    break;
  case "*":
    resultado = double.Parse(numero1) * double.Parse(numero2);
    Console.WriteLine($"Resultado é {resultado}");
    break;
  case "/":
    resultado = double.Parse(numero1) / double.Parse(numero2);
    Console.WriteLine($"Resultado é {resultado}");
    break;
  default:
    Console.WriteLine("Opção não existe.");
    break;
}
  