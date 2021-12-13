using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Escopo
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8");

        int idadeKaren = 17;
        bool acompanhado = true;

        string mensagemAdicional;
        if (acompanhado == true)
        {
            mensagemAdicional = "Karen está acompanhada!";
        }
        else
        {
            mensagemAdicional = "Karen não está acompanhada!";
        }

        if (idadeKaren >= 18 || acompanhado == true)
        {
            Console.WriteLine("Karen pode entrar!");
            Console.WriteLine(mensagemAdicional);
        }
        else
        {
            Console.WriteLine("Karen não pode entrar!");
            Console.WriteLine(mensagemAdicional);


        }
        Console.ReadLine();
    }
}
}
