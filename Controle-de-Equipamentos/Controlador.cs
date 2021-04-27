using System;

namespace Equipamentos_Junior
{
    class Controlador
    {
        private Equipamentos[] equip = new Equipamentos[0];
        private Chamados[] cham = new Chamados[0];

        internal Equipamentos[] Equip { get => equip; }
        internal Chamados[] Cham { get => cham; }

        public void cadastrarEquip(int indice, Equipamentos eq) //INDICE = -1 INDICA QUE O VALOR É NOVO, != -1 INDICA UM EDIT DE UM VALOR ANTERIOR
        {
            if (indice == -1)           
            {
                Array.Resize(ref equip, equip.Length + 1);
                equip[equip.Length - 1] = eq;
            }
            else { equip[indice - 1] = eq; }
        }
        public void cadastrarCham(int indice, Chamados c)
        {
            if (indice == -1)
            {
                Array.Resize(ref cham, cham.Length + 1);
                cham[cham.Length - 1] = c;
            }
            else { cham[indice - 1] = c; }
        }
        public void excluir(int indice, Object[] array)
        {
            for (int i = indice; i < array.Length; i++)
            {
                Object e = array[i];
                array[i - 1] = e;
            }
            if (array.Equals(equip)) { equip = (Equipamentos[])array; Array.Resize(ref equip, equip.Length - 1); }
            else if (array.Equals(cham)) { cham = (Chamados[])array; Array.Resize(ref cham, cham.Length - 1); }
        }
    }
}
