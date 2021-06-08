using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Validadores
    {

        public static bool Opcao(char opcao) {
            if (opcao != 's' & opcao != 'S' & opcao != '1' & opcao != '2' & opcao != '3' & opcao != '4' & opcao != '5' ) 
                return true; 
            else
                return false;
        }

        public static bool SegundoNumero(double valor) {
            if (valor == 0)
                return true;
            else
                return false;
        }

        public static bool OpcaoSair(char opcao) {
            if (opcao == 's' || opcao == 'S')
                return false;
            else
                return true;
        }
    }
}
