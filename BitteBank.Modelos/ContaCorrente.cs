using BitteBank.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitteBank
{
    public class ContaCorrente
    {
        public double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; set; }
        public static int QuantidadeDeContas { get; private set; }

        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            if(agencia <= 0)
            {
                throw new ArgumentException("Agência deve ser maior que zero", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("Numero deve ser maior que zero", nameof(numero));
            }

            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            
            QuantidadeDeContas++;

            TaxaOperacao = 30 / QuantidadeDeContas;
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
            if (valor < 0) throw new ArgumentException("Valor deve ser maior que zero.");


            if (PodeSacar(valor))
            {
                Saldo -= valor;
                return MensagemSucesso();
            }

            throw new SaldoInsuficienteException(valor);
        }

        public string Depositar(double valor)
        {
            Saldo += valor;

            return MensagemSucesso();
        }

        public string Transferir(double valor, ContaCorrente conta)
        {
            if (valor < 0) throw new ArgumentException("Valor inválido para transferência.");

            if (Saldo >= valor)
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
