using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaKaren = new ContaCorrente();
            contaDaKaren.titular = "Karen";
            contaDaKaren.agencia = 863;
            contaDaKaren.numero = 863542;
            contaDaKaren.saldo = 500;

            Console.WriteLine("Titular: " + contaDaKaren.titular);
            Console.WriteLine("Agência: " + contaDaKaren.agencia);
            Console.WriteLine("Número: " + contaDaKaren.numero);
            Console.WriteLine("Saldo: " + contaDaKaren.saldo);

            contaDaKaren.saldo += 500;
            Console.WriteLine("Saldo: " + contaDaKaren.saldo);
            Console.ReadLine();
        }
    }
}