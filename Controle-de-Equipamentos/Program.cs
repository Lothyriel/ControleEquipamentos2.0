using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Telas;
using Controle_de_Equipamentos.Validadores;
using System;

namespace Controle_de_Equipamentos
{
    class Program
    {
        private static void Main(string[] args)
        {
            ControladorEquip controllerE = new ControladorEquip();
            ValidadorEquip validadorE = new ValidadorEquip(controllerE);
            TelaEquip telaE = new TelaEquip(controllerE, validadorE);

            ControladorCham controllerC = new ControladorCham();
            ValidadorCham validadorC = new ValidadorCham(controllerC, controllerE);
            TelaCham telaC = new TelaCham(controllerC, validadorC, controllerE);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nDigite: ");
                Console.WriteLine("1- para visualizar o menu de equipamentos");
                Console.WriteLine("2- para visualizar o menu de chamados");
                Console.ResetColor();

                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1": telaE.menu(); break;
                    case "2": telaC.menu(); break;

                    default: erro("Comando incorreto!"); break;
                }
            }
        }
        public static void erro(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine(mensagem); Console.ResetColor();
        }
        public static bool printArray(Object[] array)
        {
            if (array.Length == 0)
            {
                erro("Nada cadastrado aqui!");
                return false;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("[" + (i + 1) + "] " + array[i]);
                }
                return true;
            }
        }
    }
}

