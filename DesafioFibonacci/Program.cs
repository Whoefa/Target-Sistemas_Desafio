using System;

class DesafioFibonacci
{

    public static bool VerificarFibonacci(int numero)
    {
        /// eleger duas variaveis auxiliares, uma vai receber o outro (Lembrando que fibonacci e a soma dos dois anteriores
      
        int a = 0;
        int b = 1;

        while (b <= numero)
        {
            if (numero == 0 || numero == 1)
            {
                return true;
            }

            int proximo = a + b;
            a = b;               
            b = proximo;         
        }
        return false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Verificar se o número pertence a sequencia fibonacci");
        Console.Write("Digite um número :");
        int numero = int.Parse(Console.ReadLine());
        
        bool resultado = VerificarFibonacci(numero);
        if (resultado == true)
        {
            Console.WriteLine("O número pertence a sequência ");
        }
        else
        {
            Console.WriteLine("Não pertence");
        }
   
    
    }

}
 