using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K10CalculaPoupanca02
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10");
        double valorInvestido = 1000;
        double rendimento = 0.0036;
        for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
        {
            valorInvestido += valorInvestido * rendimento;
            Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
        }

        Console.ReadLine();
    }
}
}
