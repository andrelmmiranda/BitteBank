using BitteBank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, 5000){
            Nome = nome;
            CPF = cpf;
        }

        public override double GetBonificacao()
        {
            return Salario * .5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
