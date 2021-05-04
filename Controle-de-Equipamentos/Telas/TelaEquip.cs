using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaEquip : Tela
    {
        private Controlador controller;

        public TelaEquip(Controlador controller) : base(controller)
        {
            this.controller = controller;
        }
    }
}
