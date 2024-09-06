using System;

public class DesafioSomaK
{
    public static void Main(string[] args)
    {
        int indice = 13, soma = 0, K = 0;

        while (K < indice)
        {
            K = K + 1;
            soma = soma + K;
            Console.WriteLine($"Para K : {K} | Soma igual a {soma}");
        }

        Console.WriteLine("\n Soma final: " + soma);
    }
}

