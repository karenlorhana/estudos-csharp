using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ConversaoTiposNumericos
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 4");

        double salario;
        salario = 1500.50;
        //o int é um tipo de variável que suporta valores até 32 bits
        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        //o long é uma variável de 64 bits
        long idade = 13000000000000;
        Console.WriteLine(idade);

        //o short pe um tipo de variável de 16 bits
        short quantidadeProdutos = 15000;
        Console.WriteLine(quantidadeProdutos);

        //
        float altura = 1.80f;
        Console.WriteLine(altura);

        Console.WriteLine("Programa finalizado, aperte enter para sair");
        Console.ReadLine();
    }
}
}