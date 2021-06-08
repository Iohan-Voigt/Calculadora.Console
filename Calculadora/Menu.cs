using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Menu
    {
        public static void MenuPrincipal()
        {
            Console.Clear();
            Program.Print("=========MENU=========\n");
            Program.Print("|                    |\n");
            Program.Print("| (1) Somar          |\n");
            Program.Print("| (2) Subtrair       |\n");
            Program.Print("| (3) Multiplicar    |\n");
            Program.Print("| (4) Dividir        |\n");
            Program.Print("| (5) Ver operações  |\n");
            Program.Print("| (s) Sair           |\n");
            Program.Print("|                    |\n");
            Program.Print("======================\n");

        }

    }
}
