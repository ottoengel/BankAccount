using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "a";
            ContaBancaria cb = new ContaBancaria();
            ContaEspecial ce = new ContaEspecial();

            Console.WriteLine("Digite o nome do titular");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a agencia");
            int agencia = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta");
            int numCon = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o saldo da conta");
            double saldo = double.Parse(Console.ReadLine());

            cb.SetNome(nome);
            cb.SetAgencia(agencia);
            cb.SetNumConta(numCon);
            cb.SetSaldo(saldo);

            Console.WriteLine(":::: Dados do cliente ::::");
            Console.WriteLine("\n- Nome: {0} \n- Agencia {1} \n- Numero da Conta {2}", cb.GetNome(), cb.GetAgencia(), cb.GetNumConta(), cb.GetSaldo());
            Console.WriteLine("------------");

            Console.WriteLine("Deseja sacar ou depositar?");
            resp = Console.ReadLine();

            if (resp == "sacar")
            {
                Console.WriteLine("Digite o valor que deseja sacar");
                double saq = double.Parse(Console.ReadLine());
                ce.SetSaldo(ce.GetSaldo() + saq);

                Console.WriteLine("Seu saldo agora é de: {0}", cb.Saque(cb.GetSaldo(), saq));
                Console.WriteLine("O seu rendimento é de: {0}", ce.Rendimento());
            }

            if (resp == "depositar")
            {
                Console.WriteLine("Digite o valor que deseja depositar");
                double dep = double.Parse(Console.ReadLine());
                ce.SetSaldo(ce.GetSaldo() + dep);

                Console.WriteLine("Seu saldo agora é de: {0}", cb.Deposito(cb.GetSaldo(), dep));
                Console.WriteLine("O seu rendimento é de: {0}", ce.Rendimento());
            }
        }
    }
}