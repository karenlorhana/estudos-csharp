using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03VariaveisFloat
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 3");
        double salario;
        salario = 1200.70;
        Console.WriteLine("O salário é de " + salario + " reais!");

        double idade;
        idade = 15.0 / 2.0;
        Console.WriteLine(idade);

        idade = 5 / 3;
        Console.WriteLine("5 / 3 = " + idade);

        idade = 5.0 / 3;
        Console.WriteLine("5.0 / 3 = " + idade);

        Console.WriteLine("A execução terminou, aperte enter para sair");
        Console.ReadLine();
    }
}
}
