using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDeDependencias
{
    public class Actor
    {
        private IAccionComun modoActuar;

        public Actor(IAccionComun _accion)
        {
            this.modoActuar = _accion;
        }

        public void Actuar()
        {
            this.modoActuar.Actuar();
        }
    }

}
