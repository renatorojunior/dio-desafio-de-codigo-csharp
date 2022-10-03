using System;
using System.Linq;

class Dio
{

    static void Main(string[] args)
    {
        // Implementando solução para verificar se o valor B corresponde aos últimos dígitos de A.
        Console.WriteLine("Quantos casos serão analisados?");      
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite o {i+1}º caso:");
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];

            if (a.Length < b.Length)
                Console.WriteLine("Não encaixa.");
            else if (a.EndsWith(b))
                Console.WriteLine("Encaixa.");
            else
                Console.WriteLine("Não encaixa.");

        }

    }

}