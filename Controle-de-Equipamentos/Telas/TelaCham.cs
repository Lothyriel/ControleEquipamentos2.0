using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaCham : Tela
    {
        private Controlador controller;
        private ControladorEquip controllerE;
        private new ValidadorCham validador;

        public TelaCham(Controlador controller, ControladorEquip controllerE)  : base(controller)
        {
            this.controller = controller;
            this.controllerE = controllerE;
            validador = (ValidadorCham)base.validador;
        }

        public override void cadastrar(int indice)
        {
            if (controllerE.Array.Length == 0) { Program.erro("Nenhum equipamento registrado!"); }
            else
            {
                base.cadastrar(indice);
            }
        }
        public override void excluir()
        {
            int opcao = 0;
            if (getIndiceArray(ref opcao) && validador.equipDependente((Equipamento)controller.Array[opcao - 1]))
            {
                Program.erro("Este equipamento está vinculado a um chamado");
            }
            else { base.excluir(); }
        }
    }
}
