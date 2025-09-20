using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2ConfrontandoSaberU2
{
    internal class SRP
    {
        public class EnviarCorreos
        {
            public void EnviarCorreo(string para, string titulo, string contenido) // Solo envía emails
            {
                Console.WriteLine($"Enviando correo a {para}: {titulo} - {contenido}");
            }
        }

        class Program
        {
            static void Main()
            {
                EnviarCorreos envio = new EnviarCorreos();
                envio.EnviarCorreo("user@example.com", "Hola", "Mensaje de prueba");
            }
        }
    }
}
