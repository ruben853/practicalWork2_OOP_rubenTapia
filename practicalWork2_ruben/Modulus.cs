using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork2_ruben
{
    public class Modulus : Operation
    {
        public Modulus()
        {

        }

        public int Operar(int op1, int op2)
        {
            if (op1 == 0 || op2 == 1) return 1;

            int dividend = Math.Abs(op1);
            int divisor = Math.Abs(op2);

            while (dividend > divisor)
            {
                dividend -= divisor;
            }
            return dividend;
        }
    }
}
