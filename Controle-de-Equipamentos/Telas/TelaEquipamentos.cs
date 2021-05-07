using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using Controle_de_Equipamentos.Validadores;

namespace Controle_de_Equipamentos.Telas
{
    class TelaEquipamentos : Tela
    {
        private new ValidadorEquipamento validador;
        public TelaEquipamentos(ControladorEquipamentos controller, ControladorChamados controllerC) : base(controller, new ValidadorEquipamento(controller, controllerC),"Tela Equipamentos")
        {
            this.controller = controller;
            validador = new ValidadorEquipamento(controller, controllerC);
        }
        public override void excluir()
        {
            int opcao = 0;
            bool indiceValido = escolherOpcaoArray(ref opcao);
            if (indiceValido && validador.equipDependente((Equipamento)controller.Registros[opcao - 1]))
            {
                Program.erro("Este equipamento está vinculado a um chamado");
            }
            else if (indiceValido) { controller.excluir(opcao); }
        }
    }
}
