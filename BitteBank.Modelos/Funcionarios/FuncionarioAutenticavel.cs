using BitteBank.Interfaces;
using BitteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha;
        public FuncionarioAutenticavel(string nome, string cpf, double salario)
            : base(nome, cpf, salario){ }

        public bool Autenticar(string senha) => _autenticacaoHelper.CompararSenha(Senha, senha);        
    }
}
