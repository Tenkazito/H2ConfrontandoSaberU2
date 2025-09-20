using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ConfrontandoSaberU2
{
    internal class OCP
    {
        //La idea es que la clase base no tenga que ser modificada sino que se pueda extender con otras clases derivadas
        public abstract class ProcesadorPago
        {
            public abstract void Procesar(decimal monto);
        }

        public class ProcesadorTarjeta : ProcesadorPago
        {
            public override void Procesar(decimal monto)
            {
                Console.WriteLine($"Procesando pago con Tarjeta: ${monto}");
            }
        }

        public class ProcesadorPayPal : ProcesadorPago
        {
            public override void Procesar(decimal monto)
            {
                Console.WriteLine($"Procesando pago con PayPal: ${monto}");
            }
        }
    }
}
