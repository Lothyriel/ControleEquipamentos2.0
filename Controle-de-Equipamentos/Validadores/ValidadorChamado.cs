using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using System;

namespace Controle_de_Equipamentos.Validadores
{
    class ValidadorChamado : Validador<Chamado>
    {
        private Controlador<Equipamento> controllerE;
        private Controlador<Solicitante> controllerS;
        public ValidadorChamado(Controlador<Chamado> controller, Controlador<Equipamento> controllerE, Controlador<Solicitante> controllerS) : base(controller)
        {
            this.controllerE = controllerE;
            this.controllerS = controllerS;
        }
        public override Chamado objetoValido()
        {
            int iEquip, iSoli;
            string desc, titulo;
            DateTime data_ab;

            while (true)
            {
                Console.WriteLine("Digite o titulo do chamado");
                titulo = Console.ReadLine(); //"1"; //
                if (titulo.Length >= 1) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite a descrição do chamado");
                desc = Console.ReadLine(); //"Celular Explodiu carregando"; //
                if (desc.Length >= 1) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número do equipamento");
                Program.printArray(controllerE.Registros);
                string equipStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(equipStr, out iEquip) && iEquip <= controllerE.Registros.Length && iEquip > 0) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite a data de abertura do chamado no formato (dd/MM/aaaa)");
                string data_abStr = Console.ReadLine(); //"27/04/2011"; //
                if (DateTime.TryParse(data_abStr, out data_ab) && data_ab.CompareTo(DateTime.Now) < 0) { break; };
            }
            while (true)
            {
                Console.WriteLine("Digite o solicitante do chamado");
                Program.printArray(controllerS.Registros);
                string soliStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(soliStr, out iSoli) && iEquip <= controllerS.Registros.Length && iSoli > 0) { break; }
            }

            return new Chamado(titulo, desc, controllerE.Registros[iEquip - 1], data_ab, controllerS.Registros[iSoli - 1]);
        }
    }
}
