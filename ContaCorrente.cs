using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public static int QuantidadeDeContas { get; private set; }

        public ContaCorrente(Cliente titular, string agencia, int numero)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            QuantidadeDeContas++;
        }

        public bool PodeSacar(double valor)
        {
            if(Saldo >= valor)
            {
                return true;
            }
            return false;
        }

        public string Sacar(double valor)
        {
            if (PodeSacar(valor))
            {
                Saldo -= valor;
                return MensagemSucesso();
            }
            return "Saldo insuficiente.";
        }

        public string Depositar(double valor)
        {
            Saldo += valor;

            return MensagemSucesso();
        }

        public string Transferir(double valor, ContaCorrente conta)
        {
            if (PodeSacar(valor))
            {
                Sacar(valor);
                conta.Depositar(valor);

                return MensagemSucesso();
            }
            return "Saldo insuficiente";
        }

        public string MensagemSucesso()
        {
            return "Operação realizada com sucesso!";
        }

        public override string ToString()
        {
            return $"Titular: {Titular.Nome} || Agência: {Agencia} || Número: {Numero} || Saldo: {Saldo}";
        }

        public static int TotalDeContas()
        {
            return ContaCorrente.QuantidadeDeContas;
        }
    }
}
