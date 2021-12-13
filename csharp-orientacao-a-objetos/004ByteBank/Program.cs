using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaKaren = new ContaCorrente();

            contaDaKaren.titular = "Karen";
            Console.WriteLine(contaDaKaren.saldo);
            bool resultadoSaque = contaDaKaren.Sacar(500);

            Console.WriteLine(contaDaKaren.saldo);
            Console.WriteLine(resultadoSaque);

            contaDaKaren.Depositar(500);
            Console.WriteLine(contaDaKaren.saldo);


            ContaCorrente contaDaLorhana = new ContaCorrente();
            contaDaLorhana.titular = "Lorhana";

            Console.WriteLine("Saldo da Karen: " + contaDaKaren.saldo);
            Console.WriteLine("Saldo da Lorhana: " + contaDaLorhana.saldo);

            bool resultadoTransferencia = contaDaKaren.Transferir(200, contaDaLorhana);
            Console.WriteLine("Saldo da Karen: " + contaDaKaren.saldo);
            Console.WriteLine("Saldo da Lorhana: " + contaDaLorhana.saldo);

            Console.WriteLine("Resultado da transferência: " + resultadoTransferencia);

            Console.ReadLine();
        }
    }
}