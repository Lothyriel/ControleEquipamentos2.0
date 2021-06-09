using Controle_de_Equipamentos.Telas;
using System;

namespace Controle_de_Equipamentos.Controladores
{
    class Controlador <T>
    {
        protected T[] registros = new T[0];

        public virtual T[] Registros { get => registros; }

        public void cadastrar(int indice, T obj)
        {
            if (indice == -1)
            {
                Array.Resize(ref registros, registros.Length + 1);
                registros[registros.Length - 1] = obj;
            }
            else { registros[indice - 1] = obj; }
        }
        public void excluir(int indice)
        {
            for (int i = indice; i < Registros.Length; i++)
            {
                Program.printArray(Registros);
                T obj = registros[i];
                registros[i - 1] = obj;
            }
            Array.Resize(ref registros, registros.Length - 1);
        }
    }
}
