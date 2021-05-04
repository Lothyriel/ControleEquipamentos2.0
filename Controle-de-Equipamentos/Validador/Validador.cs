using Controle_de_Equipamentos.Controladores;
using System;

namespace Controle_de_Equipamentos.Validadores
{
    class Validador
    {
        protected Controlador controller;
        public Validador(Controlador controller)
        {
            this.controller = controller;
        }
        public virtual Object objetoValido()
        {
            Console.WriteLine("Voce nao deveria estar vendo isto!");
            return null;
        }
        public bool itemDuplicado(Object ob)
        {
            foreach (Object o in controller.Array)
            {
                if (ob.Equals(o)) { return true; }
            }
            return false;
        }
    }
}
