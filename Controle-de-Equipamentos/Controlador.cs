using System;

namespace Equipamentos_Junior
{
    class Controlador
    {
        private Equipamentos[] equip = new Equipamentos[0];
        private Chamados[] cham = new Chamados[0];

        internal Equipamentos[] Equip { get => equip; }
        internal Chamados[] Cham { get => cham; }
        public void cadastrar(int indice, Object obj, Object[] array)
        {
            if (indice == -1)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = obj;
            }
            else { array[indice - 1] = obj; }
            //Salvando as mudanças no array da classe
            if (array.Equals(equip)) { equip = (Equipamentos[])array;}
            else if (array.Equals(cham)) { cham = (Chamados[])array;}
        }
        public void excluir(int indice, Object[] array)
        {
            for (int i = indice; i < array.Length; i++)
            {
                Object obj = array[i];
                array[i - 1] = obj;
            }
            Array.Resize(ref array, array.Length - 1);

            if (array.Equals(equip)) { equip = (Equipamentos[])array;  }
            else if (array.Equals(cham)) { cham = (Chamados[])array;}
        }
    }
}
