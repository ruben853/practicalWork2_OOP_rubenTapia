using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork2_ruben
{
    public class Divide : Operation
    {
        public Divide()
        {

        }

        public double Operar(double op1, double op2)
        {
            if(op2 == 0) return double.MaxValue;

            return (op1 / op2);
        }

        public int Operar(int op1, int op2)
        {
            if (op2 == 0) return int.MaxValue;

            return (op1 / op2);
        }
    }
}