using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaKaren = new ContaCorrente();
            contaDaKaren.titular = "Karen";
            contaDaKaren.agencia = 863;
            contaDaKaren.numero = 863452;

            ContaCorrente contaDaLorhana = new ContaCorrente();
            contaDaLorhana.titular = "Karen";
            contaDaLorhana.agencia = 863;
            contaDaLorhana.numero = 863452;

            Console.WriteLine(contaDaKaren.titular == contaDaLorhana.titular);

            if (contaDaKaren.saldo >= 100)
            {
                contaDaKaren.saldo -= 100;
            }

            Console.ReadLine();

        }
    }
}