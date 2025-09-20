using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ConfrontandoSaberU2
{
    internal class LSP
    {
        //Aunque en la subclase se modifique el comportamiento del método, sigue pudiendo hacer uso de él.
        //La subclase puede ser sustituida por la superclase sin que el programa falle.
        public class Ave
        {
            public virtual void Mover()
            {
                Console.WriteLine("El ave se mueve");
            }
        }

        public class Pinguino : Ave
        {
            public override void Mover()
            {
                Console.WriteLine("El pinguino nada");
            }
        }
    }
}
