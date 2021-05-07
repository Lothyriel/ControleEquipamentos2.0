using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaChamados : Tela
    {
        private ControladorEquipamentos controllerE;
        private ControladorSolicitante controllerS;
        private new ValidadorChamado validador;

        public TelaChamados(ControladorChamados controller, ControladorEquipamentos controllerE, ControladorSolicitante controllerS)  : base(controller, new ValidadorChamado(controller, controllerE,controllerS),"Tela Chamados")
        {
            this.controllerE = controllerE;
            this.controllerS = controllerS;
            validador = new ValidadorChamado(controller, controllerE, controllerS);
        }

        public override void cadastrar(int indice)
        {
            if (controllerE.Registros.Length == 0) { Program.erro("Nenhum equipamento registrado!"); }
            else if (controllerS.Registros.Length == 0) { Program.erro("Nenhum solicitante registrado!"); }
            else
            {
                base.cadastrar(indice);
            }
        }
    }
}
