using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06AtribuicoesVariaveis
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o programa 6");
        int idade = 19;
        int idadeKaren = idade;
        idade = 20;
        Console.WriteLine(idade);
        Console.WriteLine(idadeKaren);
        Console.ReadLine();
    }
}
}
