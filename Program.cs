public class Codigo
{
    public static void CalcularSoma()
    {
        double a, b, resultado;

        Console.WriteLine("--- Soma A+B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a + b;

        Console.WriteLine($"{a} somado com {b} é {resultado}");


        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        Console.ResetColor();

        return;
    }
    public static void CalcularSubtracao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Subtração A-B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a - b;

        Console.WriteLine($"{a} subtraindo {b} é {resultado}");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        Console.ResetColor();

        return;
    }

    public static void CalcularMultiplicacao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b;

        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        Console.ResetColor();

        return;
    }

    public static void CalcularDivisao()
    {
        double a, b, resultado;

        Console.WriteLine("--- Divisão A/B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("(A): ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("(B): ");
        b = Convert.ToDouble(Console.ReadLine());

        if (b == 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nNão é possível dividir por zero.");
            Console.ResetColor();
        }
        else
        {
            resultado = a / b;

            Console.WriteLine($"{a} dividido por {b} é {resultado}");
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        Console.ResetColor();
        return;
    }
    public static void CalcularExponenciacao()
    {
        double numero, potencia;
        Console.WriteLine("--- Exponenciação A²---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("(a):");
        numero = Convert.ToDouble(Console.ReadLine());

        potencia = Math.Pow(numero, 2);

        Console.WriteLine($"{numero} ao quadrado é:{potencia}");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        Console.ResetColor();
        return;
    }

    public static void Calcularradiciacao()

    {

        double numeroBase, indice, raiz;

        Console.WriteLine("--- Calcular radiciacao ---\n");

        Console.WriteLine("digite os valores:");

        Console.Write("A: ");
        numeroBase = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("B: ");
        indice = Convert.ToDouble(Console.ReadLine());
        
        raiz = Aritmetica.Radiciacao(numeroBase, indice);

        Console.WriteLine($"{numeroBase} radiciado {indice} é {raiz}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
        return;
    }

    public static void CalcularPorcentagem()
    {
        decimal porcentagem, numero, Resultado;
        Console.WriteLine("--- Porcentagem A%B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A:  ");
        porcentagem = Convert.ToDecimal(Console.ReadLine());
        Console.Write("B:  ");
        numero = Convert.ToDecimal(Console.ReadLine());

        Resultado = (porcentagem / 100) * numero;

        Console.WriteLine($"{porcentagem}% de {numero} é:{Resultado}");

    }

}