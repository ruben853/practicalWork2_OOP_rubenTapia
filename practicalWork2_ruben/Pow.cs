using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork2_ruben
{
    public class Pow : Operation
    {
        public Pow()
        {

        }

        public double Operar(double op1, double op2)
        {
            return 0;
        }

        public int Operar(int op1, int op2)
        {
            int result = op1;

            if (op2 == 0) return int.MaxValue;

            for (int i = 1; i <= op2; i++)
            {
                result = result * op1;
            }
            return result;
        }
    }
}
