using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitteBank.Modelos;

namespace BitteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(new Cliente("André", "1"), 1, 1);

            Console.WriteLine(cc.ToString());

            Console.ReadLine();
        }
    }
}
