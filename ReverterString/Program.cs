using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Digite um texto para ser invertidor:");
        string texto = Console.ReadLine();
        
        
        ///Vou armazenar esse texto depois imprimir de maneira decrescente
          
            string resultado = "";
            for (int i = texto.Length - 1; i >= 0; i--)
            {
                resultado += texto[i];
            }
            Console.WriteLine(resultado);
        
    }
}

   

