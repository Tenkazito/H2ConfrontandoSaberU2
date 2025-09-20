using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ConfrontandoSaberU2
{
    internal class FactoryMethod
    {
        public class Vehiculo
        {
            public string Tipo { get; }
            public Vehiculo(string tipo)
            {
                Tipo = tipo;
            }
        }

        public class Coche : Vehiculo
        {
            public Coche() : base("Coche") { }
        }

        public class Moto : Vehiculo
        {
            public Moto() : base("Moto") { }
        }

        public class FabricaVehiculos
        {
            //Literalmente crea un vehiculo segun el tipo que se le pase, como si fuera una fabrica
            //Entonces desde un input del usuario, se puede crear un vehiculo sin necesidad de saber como se crea internamente
            public Vehiculo CrearVehiculo(string tipo)
            {
                switch (tipo.ToLower())
                {
                    case "coche":
                        return new Coche();
                    case "moto":
                        return new Moto();
                    default:
                        throw new ArgumentException("Tipo inválido");
                }
            }
        }
    }
}
