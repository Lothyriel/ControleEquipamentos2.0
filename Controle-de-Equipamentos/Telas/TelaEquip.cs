using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaEquip : Tela
    {
        private new ValidadorEquip validador;
        public TelaEquip(ControladorEquip controller, ControladorCham controllerC) : base(controller, new ValidadorEquip(controller, controllerC))
        {
            this.controller = controller;
            validador = new ValidadorEquip(controller, controllerC);
        }
        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = getIndiceArray(ref opcao);
            if (indiceValido && validador.equipDependente((Equipamento)controller.Array[opcao - 1]))
            {
                Program.erro("Este equipamento está vinculado a um chamado");
            }
            else if (indiceValido) { controller.excluir(opcao); }
        }
    }
}
