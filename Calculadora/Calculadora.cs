using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        private double numero1, numero2;
        private char opcao;

        public Calculadora()
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;
            this.Opcao = opcao;
        }

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public char Opcao { get => opcao; set => opcao = value; }
    }
}
