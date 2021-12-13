using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente karen = new Cliente();
            karen.nome = "Karen";
            karen.profissao = "Desenvolvedora C#";
            karen.cpf = "123.456.759-00";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = karen;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 563527;

            conta.titular.nome = "Karen Lorhana";


            Console.WriteLine(karen.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}