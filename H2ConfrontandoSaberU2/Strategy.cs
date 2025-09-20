using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ConfrontandoSaberU2
{
    internal class Strategy
    {
        //Se aplica strategy para manejar diferentes tipos de descuentos en un carrito de compras.
        // La interfaz IDescuento define el método Aplicar, y las clases DescuentoNormal y DescuentoEspecial
        // implementan esta interfaz.
        public interface IDescuento
        {
            decimal Aplicar(decimal precio);
        }

        public class DescuentoNormal : IDescuento
        {
            public decimal Aplicar(decimal precio)
            {
                return precio; // Sin descuento
            }
        }

        public class DescuentoEspecial : IDescuento
        {
            public decimal Aplicar(decimal precio)
            {
                return precio * 0.5m; // 50% de descuento
            }
        }

        public class Carrito
        {
            private IDescuento _descuento;

            public Carrito(IDescuento descuento)
            {
                _descuento = descuento;
            }

            public decimal CalcularTotal(decimal precio)
            {
                return _descuento.Aplicar(precio);
            }
        }

        class Program
        {
            static void Main()
            {
                Carrito carrito = new Carrito(new DescuentoNormal());
                Console.WriteLine(carrito.CalcularTotal(100));

                carrito = new Carrito(new DescuentoEspecial());
                Console.WriteLine(carrito.CalcularTotal(100));
            }
        }
    }
}
