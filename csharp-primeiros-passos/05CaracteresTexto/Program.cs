using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CaracteresTexto
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5");

        //character
        char primeiraLetra = 'a';
        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char)65;
        Console.WriteLine(primeiraLetra);

        primeiraLetra = (char)(primeiraLetra + 1);
        Console.WriteLine(primeiraLetra);

        string titulo = "Karen Lorhana, " + 19 + " anos";
        Console.WriteLine(titulo);

        string cursosProgramacao =
@"- .NET 
- Java 
- JavaScript";
        Console.WriteLine(cursosProgramacao);

        Console.WriteLine("programa finalizado, clique enter para encerrar");
        Console.ReadLine();
    }
}
}
