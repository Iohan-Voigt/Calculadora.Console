using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;


namespace Calculadora{
    class Program{

        private static ArrayList log = new ArrayList();
        static void Main(string[] args){
            Calculadora valores = new Calculadora();
            do
            {
                Menu.MenuPrincipal();
                valores.Opcao = Convert.ToChar(Console.ReadLine());

                // input e validação da opção
                do
                {
                    if (valores.Opcao != 's' & valores.Opcao != 'S' & valores.Opcao != '1' & valores.Opcao != '2' & valores.Opcao != '3' & valores.Opcao != '4' & valores.Opcao != '5'){
                        Print("Dado inválido, Pressione enter para tentar novamente..");
                        Console.ReadLine();
                    }
                } while (Validadores.Opcao(valores.Opcao));
                if (valores.Opcao == 's' || valores.Opcao == 'S')
                    break;

                // este if pula direto para o log
                if(valores.Opcao != '5'){
                    Print("Digite o primeiro valor");
                    valores.Numero1 = Convert.ToDouble(Console.ReadLine());

                    // Imput e validação do segundo valor
                    do
                    {
                        Print("Digite o segundo valor");
                        valores.Numero2 = Convert.ToDouble(Console.ReadLine());
                        if (valores.Numero2 == 0 & valores.Opcao == '4')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Print("Operação inválida");
                            Console.ResetColor();
                            Print("");
                            Print("Reiniciando sistema...");
                            Thread.Sleep(2000);
                            Console.WriteLine();
                            Console.Clear();
                        }

                    } while (valores.Opcao == 4 && Validadores.SegundoNumero(valores.Numero2));
                }

                // realiza as operações
                switch (valores.Opcao) {
                    case '1'://soma
                        Print($"{valores.Numero1} {ConversorOperacao(valores.Opcao)} {valores.Numero2} = {Convert.ToString(Operacoes.Soma(valores.Numero1,valores.Numero2))}");
                        log.Add("Operação: " + valores.Numero1 + " " + ConversorOperacao(valores.Opcao) + " " + valores.Numero2 + " = " + Convert.ToString(Operacoes.Soma(valores.Numero1, valores.Numero2)));
                        break;
                    case '2'://subtração1
                        Print($"{valores.Numero1} {ConversorOperacao(valores.Opcao)} {valores.Numero2} = {Convert.ToString(Operacoes.Subtracao(valores.Numero1, valores.Numero2))}");
                        log.Add("Operação: " + valores.Numero1 + " " + ConversorOperacao(valores.Opcao) + " " + valores.Numero2 + " = " + Convert.ToString(Operacoes.Subtracao(valores.Numero1, valores.Numero2)));
                        break;
                    case '3'://multiplicaçao
                        Print($"{valores.Numero1} {ConversorOperacao(valores.Opcao)} {valores.Numero2} = {Convert.ToString(Operacoes.Multiplicacao(valores.Numero1, valores.Numero2))}");
                        log.Add("Operação: " + valores.Numero1 + " " + ConversorOperacao(valores.Opcao) + " " + valores.Numero2 + " = " + Convert.ToString(Operacoes.Multiplicacao(valores.Numero1, valores.Numero2)));
                        break;
                    case '4'://divisão
                        Print($"{valores.Numero1} {ConversorOperacao(valores.Opcao)} {valores.Numero2} = {Convert.ToString(Operacoes.Subtracao(valores.Numero1, valores.Numero2))}");
                        log.Add("Operação: " + valores.Numero1 + " " + ConversorOperacao(valores.Opcao) + " " + valores.Numero2 + " = " + Convert.ToString(Operacoes.Divisao(valores.Numero1, valores.Numero2)));
                        break;
                    case '5'://log

                        if (log.Count == 0)
                        {
                            Console.WriteLine("Hitórico vazio.");
                        }
                        else {
                            foreach (String aux2 in log){
                                Console.WriteLine(aux2);
                            }
                        }
                        break;
                    case 's':
                        break;
                }
                Print("\nConcluido. pressione qualquer tecla para continuar.");
                Console.ReadLine();

            } while (Validadores.OpcaoSair(valores.Opcao));
        }


        public static void Print(string entrada){
            Console.Write(entrada);
        }

        public static char ConversorOperacao(char opcao) {
            switch (opcao) {
                case '1':
                    return '+';
                case '2':
                    return '-';
                case '3':
                    return '*';
                case '4':
                    return '/';
            }
            return '/';
        }
    }
}
