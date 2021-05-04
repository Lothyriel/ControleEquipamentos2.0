﻿using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;
using System;

namespace Controle_de_Equipamentos.Telas
{
    class Tela
    {
        private Controlador controller;
        private Validador validador;
        public Tela(Controlador controller, Validador validador)
        {
            this.controller = controller;
            this.validador = validador;
        }

        public void menu()
        {
            Console.WriteLine("1- para visualizar registros");
            Console.WriteLine("2- para cadastrar novos registros");
            Console.WriteLine("3- para editar registros");
            Console.WriteLine("4- para excluir registros\n");
            Console.WriteLine("0- para voltar");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": Program.printArray(controller.Array); break;
                case "2": cadastrar(-1); break;
                case "3": edit(); break;
                case "4": excluir(); break;
                case "0": break;

                default: Program.erro("Comando incorreto!"); break;
            }
        }
        protected bool getIndiceArray(ref int opcaoInt)
        {
            while (true)
            {
                Console.WriteLine("Digite o indice para editar ou digite 0 para cancelar");
                if (!Program.printArray(controller.Array)) { return false; }
                string opcao = Console.ReadLine();
                if (opcao == "0") { return false; }

                if (!int.TryParse(opcao, out opcaoInt) || opcaoInt < 0 || opcaoInt > controller.Array.Length) { continue; }

                return true;
            }
        }
        public virtual void cadastrar(int indice)
        {
            Object obj = validador.objetoValido();

            if (validador.itemDuplicado(obj) && indice == -1) { Program.erro("Item já esta cadastrado"); }

            else
            {
                controller.cadastrar(indice, obj);
            }
        }
        public virtual void excluir()
        {
            int opcaoInt = 0;
            if (getIndiceArray(ref opcaoInt))
            {
                controller.excluir(opcaoInt);
            }
        }
        public virtual void edit()
        {
            int opcaoInt = 0;
            if (getIndiceArray(ref opcaoInt))
            {
                cadastrar(opcaoInt);
            }
        }
    }
}
