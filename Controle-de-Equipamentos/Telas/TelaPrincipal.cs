using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Equipamentos.Telas
{
    class TelaPrincipal
    {
        public TelaPrincipal()
        {
            ControladorEquip controllerE = new ControladorEquip();
            ControladorCham controllerC = new ControladorCham();

            Tela tela;

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
                    case "1": tela = new TelaEquip(controllerE); break;
                    case "2": tela = new TelaCham(controllerC,controllerE); break;

                    default: Program.erro("Comando incorreto!"); break;
                }
            }
        }
    }
}
