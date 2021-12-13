using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CriandoVariaveis
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 2");
        int idade;
        idade = 19;
        Console.WriteLine(idade);
        idade = 19 + 1;
        Console.WriteLine(idade);
        idade = (19 + 1) * 2;
        Console.WriteLine("Sua idade é " + idade + "!");
        Console.WriteLine("Aperte enter para sair");
        Console.ReadLine();
    }
}
}