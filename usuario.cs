string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 7 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[x] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[%] porcentagem ");
Console.WriteLine("[E] Exponenciação");
Console.WriteLine("[R] radiciação");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Codigo.CalcularSoma();
        break;

    case "-":
        Codigo.CalcularSubtracao();
        break;

    case "x":
        Codigo.CalcularMultiplicacao();
        break;

    case "/":
        Codigo.CalcularDivisao();
        break;

    case "e":
        Codigo.CalcularExponenciacao();
        break;

    case "r":
        Codigo.Calcularradiciacao();
        break;

    default:
        Console.WriteLine("Opção inválida.");
        break;
   
    case "%":
        Codigo.CalcularPorcentagem();
        break;
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("programa feito por Thiago Lopes Periera-1I3-");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("OBRIGADO POR UTILIZAR MINHA CALCULADORA");
Console.ResetColor();