using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Program programa = new Program(); 
            programa.CalcularBonificacao();
            */
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            
            Diretor roberta = new Diretor("987.654.321-00");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("741.852.963-00");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "1234";

            sistemaInterno.Logar(parceiro, "1234");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");

           
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            Designer pedro = new Designer("123.456.789-00");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("987.654.321-00");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("456.789.123-00");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("741.852.963-00");
            camila.Nome = "Camila";

            Desenvolvedor karen = new Desenvolvedor("147.258.369-00");
            karen.Nome = "Karen";
            
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(karen);

            Console.WriteLine("Total de bonificações no mês: " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
} 
