using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaCham : Tela
    {
        private ControladorEquip controllerE;
        private new ValidadorCham validador;

        public TelaCham(ControladorCham controller, ControladorEquip controllerE)  : base(controller, new ValidadorCham(controller, controllerE))
        {
            this.controllerE = controllerE;
            validador = new ValidadorCham(controller, controllerE);
        }

        public override void cadastrar(int indice)
        {
            if (controllerE == null||controllerE.Array == null||controllerE.Array.Length==0) { Program.erro("Nenhum equipamento registrado!"); }
            else
            {
                base.cadastrar(indice);
            }
        }
        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = getIndiceArray(ref opcao);
            if (indiceValido && validador.equipDependente((Equipamento)controller.Array[opcao - 1]))
            {
                Program.erro("Este equipamento está vinculado a um chamado");
            }
            else if(indiceValido){ base.excluir(); }
        }
    }
}
