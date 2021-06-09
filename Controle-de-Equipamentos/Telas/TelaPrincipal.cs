﻿using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using System;

namespace Controle_de_Equipamentos.Telas
{
    class TelaPrincipal
    {
        private Controlador<Equipamento> controllerE = new Controlador<Equipamento>();
        private Controlador<Chamado> controllerC = new Controlador<Chamado>();
        private Controlador<Solicitante> controllerS = new Controlador<Solicitante>();
        private dynamic tela;
        public TelaPrincipal()
        {
            while (true)
            {
                tela = selecionarTela();
                tela.menu();
            }
        }
        public dynamic selecionarTela()
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
                    case "1": return new TelaEquipamentos(controllerE, controllerC);
                    case "2": return new TelaChamados(controllerC, controllerE, controllerS);
                    case "3": return new TelaSolicitantes(controllerS);

                    default: Program.erro("Comando incorreto!"); return null;
                }
            }
        }
    }
}
