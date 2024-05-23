using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork2_ruben
{
    public class Substract : Operation
    {
        public Substract()
        {

        }

        public double Operar(double op1, double op2)
        {
            return op1 - op2;
        }

        public int Operar(int op1, int op2) 
        {
            return op1 - op2;
        }
    }
}
