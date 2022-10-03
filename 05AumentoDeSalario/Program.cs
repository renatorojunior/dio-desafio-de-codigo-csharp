using System;

class DIO
{

    static void Main(string[] args)
    {
        //Desenvolvendo solução para reajustar salários dos funcionários de uma empresa:
        double salario = 0.00;
        double reajuste = 0.00;
        double novoSalario = 0.00;
        double percentual = 0.00;

        Console.WriteLine("Qual o valor do salário que deseja reajustar?");
        salario = Convert.ToDouble(Console.ReadLine());

        if (salario < 0.00)
        {
            return;

        }
        else if (salario <= 400.00)
        {
            percentual = 0.15;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;


        }
        else if (salario >= 400.01 && salario <= 800.00)
        {
            percentual = 0.12;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;

        }
        else if (salario >= 800.01 && salario <= 1200.00)
        {
            percentual = 0.1;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;

        }
        else if (salario >= 1200.01 && salario <= 2000.00)
        {
            percentual = 0.07;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;

        }
        else
        {
            percentual = 0.04;
            reajuste = salario * percentual;
            novoSalario = salario + reajuste;

        }

        Console.WriteLine($"Novo salario: {novoSalario}");
        Console.WriteLine($"Reajuste ganho: {reajuste}");
        Console.WriteLine($"Em percentual: {percentual * 100} %");

    }
}

