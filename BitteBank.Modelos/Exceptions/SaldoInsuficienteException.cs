using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitteBank.Exceptions
{
    public class SaldoInsuficienteException: Exception
    {
        public double Valor { get; }
        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(string message) : base(message) { }

        public SaldoInsuficienteException(double valorSaque)
            : this($"Tentativa de saque no valor de R$ {valorSaque}. Saldo insuficiente.")
        {
            Valor = valorSaque;
        }
    }
}
