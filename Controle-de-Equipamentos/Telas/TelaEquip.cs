using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaEquip : Tela
    {
        public TelaEquip(ControladorEquip controller) : base(controller, new ValidadorEquip(controller))
        {
            this.controller = controller;
            validador = new ValidadorEquip(controller);
        }
    }
}
