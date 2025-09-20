using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ConfrontandoSaberU2
{
    internal class Pilares
    {
        // Ejemplo de pilares de la Programacion Orientada a Objetos (POO)
        public abstract class Animal
        {
            private string Nombre { get; set; } // Al ponerlo en private se esta aplicando encapsulamiento

            public Animal(string nombre)
            {
                Nombre = nombre;
            }

            public string GetNombre()
            {
                return Nombre;
            }

            public abstract string HacerSonido(); // Se aplica abstraccion para que lo usen las clases que hereden
        }

        // Clase que hereda de Animal
        public class Perro : Animal
        {
            public Perro(string nombre) : base(nombre) { }

            public override string HacerSonido() // Al cambiar el metodo, se esta aplicando polimorfismo
            {
                return "Guau!";
            }
        }
    }
}
