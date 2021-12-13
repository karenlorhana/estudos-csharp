using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CalculaPoupanca
{
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o programa 09");
        double valorInvestido = 1000;
        int contadorMes = 1;
        double rendimento = 0.0036;
        while (contadorMes <= 12)
        {

            valorInvestido += valorInvestido * rendimento;
            Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);
            contadorMes += 1;
        }
        Console.ReadLine();
    }
}
}