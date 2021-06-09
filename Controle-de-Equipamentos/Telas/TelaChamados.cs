using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaChamados : Tela<Chamado>
    {
        private Controlador<Equipamento> controllerE;
        private Controlador<Solicitante> controllerS;

        public TelaChamados(Controlador<Chamado> controller, Controlador<Equipamento> controllerE, Controlador<Solicitante> controllerS) : base(controller, new ValidadorChamado(controller, controllerE, controllerS), "Tela Chamados")
        {
            this.controllerE = controllerE;
            this.controllerS = controllerS;
        }

        public override void cadastrar(int indice)
        {
            if (controllerE.Registros.Length == 0)
                Program.erro("Nenhum equipamento registrado!");
            else if (controllerS.Registros.Length == 0)
                Program.erro("Nenhum solicitante registrado!");
            else
                base.cadastrar(indice);
        }
    }
}
