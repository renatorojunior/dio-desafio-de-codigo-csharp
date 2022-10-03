using System;

class DIO
{
    public static void Main()
    {
        // Desenvolvendo solução para classificar o nível da tartaruga mais veloz de um determinado grupo:
        int quantidadeEntradas = 3;

        while (quantidadeEntradas > 0)
        {
            Console.WriteLine("Quantas tartarugas possui o grupo?");
            var numeroQuantidade = Int32.Parse(Console.ReadLine());

            if (numeroQuantidade >= 1 && numeroQuantidade <= 500)
            {
                Console.WriteLine("Indique as velocidades máximas das tartarugas que pertencem ao grupo:");
                string[] tartarugas = Console.ReadLine().Split(" ");
                var maiorVelocidade = Int32.Parse(tartarugas[0]);

                for (int i = 0; i < tartarugas.Length; i++)
                {
                    var tartaruga = Int32.Parse(tartarugas[i]);

                    if (tartaruga > maiorVelocidade)
                    {
                        maiorVelocidade = tartaruga;
                    }
                }

                if (maiorVelocidade < 10)
                {
                    Console.WriteLine("A tartaruga mais veloz deste grupo é de nível 1.");
                }
                else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
                {
                    Console.WriteLine("A tartaruga mais veloz deste grupo é de nível 2.");
                }
                else if (maiorVelocidade >= 20)
                {
                    Console.WriteLine("A tartaruga mais veloz deste grupo é de nível 3.");
                }
                quantidadeEntradas--;
            }
            else
            {
                Console.WriteLine("Insira um número entre 1 e 500");
            }
        }
    }
}