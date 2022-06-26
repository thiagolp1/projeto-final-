public class Aritmetica
{
    public static double Soma(double parcela1, double parcela2)
    {
        double total = parcela1 + parcela2;
        return total;
    }
        public static double Subtracao(double minuendo, double subtraendo)
    {
        double diferenca = minuendo - subtraendo;
        return diferenca;
    }

    public static double Multiplicacao(double fator1, double fator2)
    {
        double produto = fator1 * fator2;
        return produto;
    }
     public static double Divisao(double dividendo, double divisor )

     { if (divisor == 0)
     
    {
    Console.BackgroundColor = ConsoleColor.DarkRed;
        throw new Exception("Não é possível dividir por zero.");
    }
    Console.ResetColor();

    double quociente  = dividendo / divisor;
    return quociente;
     }
    public static double Exponenciação(double numero, double potencia)
    {
        potencia = Math.Pow(numero,2);
        return numero;
    }
public static double Radiciacao(double numeroBase, double indice)
{
    double raiz = Math.Pow(numeroBase, 1 / indice);
    return raiz;
}

public static decimal Porcentagem(decimal  porcentagem,  decimal numero )
    {
        decimal resultado = porcentagem /100 * numero;
        return porcentagem;
    }


}
