using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ContaBancaria
    {
        string NomeTitular;
        int agencia;
        int numConta;
        double saldo;


        public double Saque(double saldoConta, double valorSaque)
        {
            return saldoConta - valorSaque;
        }

        public double Deposito(double saldoConta, double valorDeposito)
        {
            return saldoConta + valorDeposito;
        }

        public string GetNome()
        {
            return NomeTitular;
        }

        public void SetNome(string nom)
        {
            NomeTitular = nom;
        }

        public int GetAgencia()
        {
            return agencia;
        }

        public void SetAgencia(int agen)
        {
            agencia = agen;
        }
        public int GetNumConta()
        {
            return numConta;
        }

        public void SetNumConta(int ncon)
        {
            numConta = ncon;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double sald)
        {
            saldo = sald;
        }

    }
}