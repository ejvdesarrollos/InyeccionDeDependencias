using System;

namespace InyeccionDeDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            //defino a un actor que puede ser Policia o Ladron
            //En el constructor mando una Interfaz, pero al llamarlo, lo hago con un objeto que implementa dicha interfaz.
            Actor oAccion = new Actor(new Policia());
            oAccion.Actuar();
        }
    }
}
