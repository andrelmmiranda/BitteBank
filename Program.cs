using BitteBank.Funcionarios;
using BitteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diretor d1 = new Diretor("Pablo Vittar","0001", 5000);

            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            gerenciadorBonificacao.Registrar(d1);

            Console.WriteLine($"Salário: {d1.Salario}");

            d1.AumentarSalario();

            Console.WriteLine($"Salário: {d1.Salario}");

            Console.WriteLine($"Total Bonus: {gerenciadorBonificacao.GetTotalBonificacao()}");

            d1.Senha = "123";


            SistemaInterno sistemaInterno = new SistemaInterno();

            sistemaInterno.Logar(d1, "123");

            Console.ReadKey();
        }
    }
}
