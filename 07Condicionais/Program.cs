using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Condicionais
{
internal class Program
{
        static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7");

        int idadeKaren = 17;
        //int quantidadePessoas = 2;
        //bool acompanhado = quantidadePessoas >= 2;
        bool acompanhado = false;

        if (idadeKaren >= 18 || acompanhado == true)
        {
            Console.WriteLine("Karen pode entrar!");
        }
        else
        {
            Console.WriteLine("Karen não pode entrar!");


        }
        Console.ReadLine();
    }
}
}
