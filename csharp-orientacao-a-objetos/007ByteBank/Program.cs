using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            ContaCorrente contaDaKaren = new ContaCorrente(867, 86755540);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);

            Console.ReadLine();
        }
    }
}
