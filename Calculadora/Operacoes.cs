using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacoes
    {
        public static double Soma(double n1, double n2) {
            return (n1 + n2);
        }

        public static double Subtracao(double n1, double n2) {
            return (n1 - n2);
        }

        public static double Multiplicacao(double n1, double n2) {
            return(n1 * n2);
        }

        public static double Divisao(double n1, double n2) {
            return (n1 / n2);
        }
    }
}
