using System;

namespace Controle_de_Equipamentos.Controladores
{
    class Controlador
    {
        private Object[] array = new Object[0];

        public virtual object[] Array { get => array;}

        public virtual void cadastrar(int indice, Object obj)
        {
            if (indice == -1)
            {
                System.Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = obj;
            }
            else { array[indice - 1] = obj; }
            //Salvando as mudanças no array da classe
        }
        public virtual void excluir(int indice)
        {
            for (int i = indice; i < array.Length; i++)
            {
                Object obj = array[i];
                array[i - 1] = obj;
            }
            System.Array.Resize(ref array, array.Length - 1);
        }
    }
}