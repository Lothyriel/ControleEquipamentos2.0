using Controle_de_Equipamentos.Domínio;
using System;

namespace Controle_de_Equipamentos.Controladores
{
    class ControladorEquipamentos : Controlador
    {
        public override Object[] Registros { get => equipamentos(); }

        public Equipamento[] equipamentos()
        {
            Equipamento[] equips = new Equipamento[registros.Length];
            Array.Copy(registros, equips, registros.Length);
            return equips;
        }
    }
}
