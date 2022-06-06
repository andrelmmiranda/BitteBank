using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public bool CompararSenha(string senha, string senhaTentativa)
        {
            return senha == senhaTentativa;
        }
    }
}
