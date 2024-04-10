using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Fatorial
    {
        public int CalculoFatorial(int valor)
        {
            if(valor ==1) return 1;
            return valor * CalculoFatorial(--valor);
        }
    }
}
