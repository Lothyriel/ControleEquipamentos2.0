using System;
using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaChamados : Tela
    {
        private ControladorEquipamentos controllerE;
        private new ValidadorCham validador;

        public TelaChamados(ControladorChamados controller, ControladorEquipamentos controllerE)  : base(controller, new ValidadorCham(controller, controllerE),"Tela Chamados")
        {
            this.controllerE = controllerE;
            validador = new ValidadorCham(controller, controllerE);
        }

        public override void cadastrar(int indice)
        {
            if (controllerE == null||controllerE.Registros == null||controllerE.Registros.Length==0) { Program.erro("Nenhum equipamento registrado!"); }
            else
            {
                base.cadastrar(indice);
            }
        }
    }
}
