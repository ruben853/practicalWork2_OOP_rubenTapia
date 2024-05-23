using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicalWork2_ruben
{
    public class Operation
    {
        protected string ecuacion;

        protected string simbolo;
        protected double elemento1;
        protected double elemento2;
        protected int elemento1_int;
        protected int elemento2_int;


        protected string result;
        public Operation(string ecuacion)
        {
            this.ecuacion = ecuacion;
        }

        public Operation()
        {

        }

        public string Calcular()
        {
            string[] elementos = this.ecuacion.Split(' ');

            this.elemento1 = double.Parse(elementos[0]);
            this.simbolo = (elementos[1]);
            this.elemento2 = double.Parse(elementos[2]);
            this.elemento1_int = int.Parse(elementos[0]);
            this.elemento2_int = int.Parse(elementos[2]);

            switch (this.simbolo)
            {
                case "+":
                    Add a = new Add();
                    this.result = Convert.ToString(a.Operar(this.elemento1, this.elemento2));
                    //Console.WriteLine(this.result);
                    break;

                case "-":
                    Substract s = new Substract();
                    this.result = Convert.ToString(s.Operar(this.elemento1, this.elemento2));
                    //Console.WriteLine(this.result);

                    break;

                case "*":
                   Multiply m = new Multiply();
                    this.result = Convert.ToString(m.Operar(this.elemento1, this.elemento2));
                    Console.WriteLine(this.result);
                    break;

                case "/":
                    Divide d = new Divide();
                    this.result = Convert.ToString(d.Operar(this.elemento1, this.elemento2));
                    //Console.WriteLine(this.result);
                    break;

                case "^":
                    if (this.ecuacion.Contains(','))
                    {
                        Pow p = new Pow();
                        this.result = Convert.ToString(p.Operar(this.elemento1_int, this.elemento2_int));
                    }
                    //Console.WriteLine(this.result);
                    break;

                case "mod":
                    if (this.ecuacion.Contains(','))
                    {
                        Pow p = new Pow();
                        this.result = Convert.ToString(p.Operar(this.elemento1_int, this.elemento2_int));
                    }
                    //Console.WriteLine(this.result);
                    break;
            }
            return this.result;
        }
    }
}

