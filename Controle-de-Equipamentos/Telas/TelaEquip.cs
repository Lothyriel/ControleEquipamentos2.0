using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaEquip : Tela
    {
        private Controlador controller;
        private Validador validador;
        public TelaEquip(Controlador controller, Validador validador) : base(controller, validador)
        {
            this.controller = controller;
            this.validador = validador;
        }
    }
}
