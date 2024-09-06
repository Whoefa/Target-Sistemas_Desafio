using System;

public class Program
{
    public static void Main(string[] args)
    {
        double distribuidoraSP = 67836.43;
        double distribuidoraRJ = 36678.66;
        double distribuidoraMG = 29229.88;
        double distribuidoraES = 27165.48;
        double Outros = 19849.53;
        double faturamentoTotal = distribuidoraSP + distribuidoraRJ + distribuidoraMG + distribuidoraES + Outros;

        
        Console.WriteLine($"O faturamento total é: R${faturamentoTotal}");
        Console.WriteLine("O Faturamento por empresa:");


        double representanteRJ = (distribuidoraRJ / faturamentoTotal) * 100;
        Console.WriteLine($"Percentual RJ :{representanteRJ:F2} %");


        double representanteSP = (distribuidoraSP / faturamentoTotal) * 100;
        Console.WriteLine($"Percentual SP :{representanteSP:F2} %");


        double representanteMG = (distribuidoraMG / faturamentoTotal) * 100;
        Console.WriteLine($"Percentual MG :{representanteMG:F2} %");


        double representanteES = (distribuidoraES / faturamentoTotal) * 100;
        Console.WriteLine($"Percentual ES :{representanteES:F2} %");

        double outrosRepresentantes = (Outros / faturamentoTotal) * 100;
        Console.WriteLine($"Percentual Outros  :{outrosRepresentantes:F2} %");
    }
}
