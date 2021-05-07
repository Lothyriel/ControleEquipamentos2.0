using Controle_de_Equipamentos.Controladores;
using System;

namespace Controle_de_Equipamentos.Telas
{
    class TelaPrincipal
    {
        private ControladorEquipamentos controllerE = new ControladorEquipamentos();
        private ControladorChamados controllerC = new ControladorChamados();
        private ControladorSolicitante controllerS = new ControladorSolicitante();
        private Tela tela = null;

        public TelaPrincipal()
        {
            while (true)
            {
                tela = selecionarTela();
                tela.menu();
            }
        }
        public Tela selecionarTela()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nDigite: ");
                Console.WriteLine("1- para visualizar o menu de equipamentos");
                Console.WriteLine("2- para visualizar o menu de chamados");
                Console.WriteLine("3- para visualizar o menu de solicitantes");
                Console.ResetColor();

                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1": tela = new TelaEquipamentos(controllerE, controllerC); break;
                    case "2": tela = new TelaChamados(controllerC, controllerE); break;
                    case "3": tela = new TelaSolicitantes(controllerS); break;

                    default: Program.erro("Comando incorreto!"); break;
                }
                return tela;
            }
        }
    }
}
