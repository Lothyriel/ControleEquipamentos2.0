using Controle_de_Equipamentos.Controladores;

namespace Controle_de_Equipamentos.Validadores
{
    abstract class Validador<T>
    {
        protected Controlador<T> controller;
        public Validador(Controlador<T> controller)
        {
            this.controller = controller;
        }
        public abstract T objetoValido();
        public bool itemDuplicado(T ob)
        {
            foreach (T o in controller.Registros)
            {
                if (ob.Equals(o)) { return true; }
            }
            return false;
        }
    }
}
