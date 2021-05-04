using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaCham : Tela
    {
        private Controlador controller;
        private ValidadorCham validador;
        private ControladorEquip controllerE;
        public TelaCham(Controlador controller, Validador validador, ControladorEquip controllerE)  : base(controller, validador)
        {
            this.controller = controller;
            this.validador = (ValidadorCham)validador;
            this.controllerE = controllerE;
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
