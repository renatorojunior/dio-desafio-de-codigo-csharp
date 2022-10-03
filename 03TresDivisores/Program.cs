using System;

class DIO
{
        
    public static void Main(string[] args)
    {
        // Implementando solução para verificar se um número n tem exatamente três divisores positivos.
        Console.WriteLine("Qual número deseja verificar?");
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
            if (count > 3)
            {
                Console.WriteLine(false);
            }
        }

        if(count == 3)
        {
            Console.WriteLine($"O número {n} tem exatamente 3 divisores.");
        }
        else
        {
            Console.WriteLine($"O número {n} não tem exatamente 3 divisores.");
        }
    }
}
