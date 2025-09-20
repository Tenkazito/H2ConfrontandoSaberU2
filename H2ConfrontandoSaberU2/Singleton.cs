using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ConfrontandoSaberU2
{
    internal class Singleton
    {
        public class Registro
        {
            private static Registro _instancia;

            private Registro() { }

            public static Registro Instancia //Propiedad que devuelve la instancia única
            {
                get
                {
                    if (_instancia == null)
                        _instancia = new Registro();
                    return _instancia;
                }
            }

            public void Guardar(string mensaje)
            {
                Console.WriteLine($"Registro: {mensaje}");
            }
        }

        class Programa
        {
            static void Main()
            {
                Registro registro1 = Registro.Instancia;
                registro1.Guardar("Hola");

                Registro registro2 = Registro.Instancia;
                registro2.Guardar("Mundo");

                //La idea es que aunque se creen varios objetos, todos apunten a la misma instancia, solo hay una
            }
        }
    }
}
