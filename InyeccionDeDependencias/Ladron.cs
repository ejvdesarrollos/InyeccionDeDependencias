using System;
using System.Collections.Generic;
using System.Text;

namespace InyeccionDeDependencias
{
    public class Ladron : IAccionComun
    {
        public void Actuar()
        {
            Console.WriteLine("Soy ladron");
        }
    }
}
