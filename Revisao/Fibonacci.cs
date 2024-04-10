using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Fibonacci
    {
        public int CalculoFibonacci(int posicao)
        {
            if (posicao == 1) return 1;
            if (posicao == 2) return 1;
            return (CalculoFibonacci(posicao - 1) + CalculoFibonacci(posicao - 2));
        }
    }
}
