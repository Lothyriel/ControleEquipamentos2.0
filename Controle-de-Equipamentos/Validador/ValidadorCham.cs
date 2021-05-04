﻿using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using System;

namespace Controle_de_Equipamentos.Validadores
{
    class ValidadorCham : Validador
    {
        private Controlador controller;
        private ControladorEquip controllerE;
        public ValidadorCham(Controlador controller,ControladorEquip controllerE) : base(controller)
        {
            this.controller = controller;
            this.controllerE = controllerE;
        }
        public override Object objetoValido()
        {
            int iEquip;
            string desc, titulo;
            DateTime data_ab;

            while (true)
            {
                Console.WriteLine("Digite o titulo do chamado");
                titulo = Console.ReadLine(); //"1"; //
                if (titulo.Length >= 1) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite a descrição do chamado");
                desc = Console.ReadLine(); //"Celular Explodiu carregando"; //
                if (desc.Length >= 1) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número do equipamento");
                Program.printArray(controllerE.Array);
                string equipStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(equipStr, out iEquip) && iEquip <= controllerE.Array.Length && iEquip > 0) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite a data de abertura do chamado no formato (dd/MM/aaaa)");
                string data_abStr = Console.ReadLine(); //"27/04/2011"; //
                if (DateTime.TryParse(data_abStr, out data_ab) && data_ab.CompareTo(DateTime.Now) < 0) { break; };
            }

            return new Chamado(titulo, desc, (Equipamento)controllerE.Array[iEquip - 1], data_ab);
        }
        public bool equipDependente(Equipamento eq)
        {
            foreach (Chamado c in controllerE.Array)
            {
                if (c.Equipamento == eq) return true;
            }
            return false;
        }
    }
}
