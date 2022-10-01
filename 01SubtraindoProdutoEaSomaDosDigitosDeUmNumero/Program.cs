using System;

class DIO
{

    static void Main(string[] args)
    {
        //Desenvolvendo aplicação para subtrair o produto e a soma de um número inteiro.
        int n, ni, produto, soma, diferença;

        Console.WriteLine("Digite o número que deseja calcular a diferença entre o produto e a soma:");
        n = int.Parse(Console.ReadLine());
        ni = n;
        produto = 1;
        soma = 0;
        

        while (ni > 0)
        {
            int l = ni % 10;
            
            produto *= l;
            soma += l;
            ni /= 10;
        }

        diferença = produto - soma;

        Console.WriteLine($"A diferença entre a soma e o produto dos digitos do número inteiro {n} é {diferença}.");
    }
}
