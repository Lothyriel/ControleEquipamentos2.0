using Controle_de_Equipamentos.Controladores;
using System;

namespace Controle_de_Equipamentos.Telas
{
    class TelaPrincipal
    {
        public TelaPrincipal()
        {
            ControladorEquip controllerE = new ControladorEquip();
            ControladorCham controllerC = new ControladorCham();

            TelaEquip telaE = new TelaEquip(controllerE);
            TelaCham telaC = new TelaCham(controllerC, controllerE);

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

                    default: Program.erro("Comando incorreto!"); break;
                }
            }
        }
    }
}
