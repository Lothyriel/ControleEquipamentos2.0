using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaSolicitantes : Tela
    {
        public TelaSolicitantes(ControladorSolicitante controller) : base(controller, new ValidadorSolicitante(controller), "Tela Solicitantes")
        {
            this.controller = controller;
        }
    }
}
