using Controle_de_Equipamentos.Controladores;
using Controle_de_Equipamentos.Domínio;
using System;

namespace Controle_de_Equipamentos.Validadores
{
    class ValidadorEquip : Validador
    {
        private ControladorCham controllerC;
        public ValidadorEquip(Controlador controller,ControladorCham controllerC) : base(controller)
        {
            this.controllerC = controllerC;
        }
        public override Object objetoValido()
        {
            int nro_serie;
            double preco;
            string nome, fabricante;
            DateTime data_fabr;

            while (true)
            {
                Console.WriteLine("Digite o nome do equipamento");
                nome = Console.ReadLine(); //"VOLT TV"; // 
                if (nome.Length > 5) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o preço do equipamento");
                string precoStr = Console.ReadLine(); //"3000"; // 
                if (double.TryParse(precoStr, out preco)) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite o número de série do equipamento (números)");
                string nro_serieStr = Console.ReadLine(); //"1000"; //
                if (int.TryParse(nro_serieStr, out nro_serie)) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite a data de fabricação do equipamento no formato (dd/MM/aaaa)");
                string data_fabrStr = Console.ReadLine(); //"27/04/2001"; //
                if (DateTime.TryParse(data_fabrStr, out data_fabr) && data_fabr.CompareTo(DateTime.Now) < 0) { break; };
            }
            while (true)
            {
                Console.WriteLine("Digite o fabricante do equipamento");
                fabricante = Console.ReadLine(); //"LG"; //
                if (fabricante.Length > 1) { break; }
            }
            return new Equipamento(nome, preco, nro_serie, data_fabr, fabricante);
        }
        public bool equipDependente(Equipamento eq)
        {
            foreach (Chamado c in controllerC.Array)
            {
                if (c.Equipamento == eq) return true;
            }
            return false;
        }
    }
}
