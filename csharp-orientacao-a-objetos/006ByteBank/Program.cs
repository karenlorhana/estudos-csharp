using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.Nome = "Karen";
            cliente.CPF = "123.456.789-00";
            cliente.Profissao = "Desenvolvedora";

            conta.Saldo = -10;
            conta.Titular = cliente;

            
            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
