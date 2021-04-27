using System;
using System.Collections.Generic;
using System.Linq;

namespace Equipamentos_Junior
{
    class Validador
    {
        public static Equipamentos equipValido()
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

            return new Equipamentos(nome, preco, nro_serie, data_fabr, fabricante);
        }
        public static Chamados chamadoValido(Equipamentos[] equips)
        {
            int iEquip;
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
                Program.printArray(equips);
                string equipStr = Console.ReadLine(); //"1"; //
                if (int.TryParse(equipStr, out iEquip) && iEquip <= equips.Length && iEquip > 0) { break; }
            }
            while (true)
            {
                Console.WriteLine("Digite a data de abertura do chamado no formato (dd/MM/aaaa)");
                string data_abStr = Console.ReadLine(); //"27/04/2011"; //
                if (DateTime.TryParse(data_abStr, out data_ab) && data_ab.CompareTo(DateTime.Now) < 0) { break; };
            }

            return new Chamados(titulo, desc, equips[iEquip - 1], data_ab);
        }
        public static bool equipDependente(Chamados[] cham, Equipamentos eq)
        {
            foreach (Chamados c in cham)
            {
                if (c.Equipamento == eq) return true;
            }
            return false;
        }
        public static bool itemDuplicado(Object[] array, Object ob)
        {
            foreach (Object o in array)
            {
                if (ob.Equals(o)) { return true; }
            }
            return false;
        }
    }
}
