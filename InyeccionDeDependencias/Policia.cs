using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDeDependencias
{
    public class Policia : IAccionComun
    {
        public void Actuar()
        {
            Console.Write("Soy policia");
        }
    }
}
