using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorNaftero : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando el motor naftero...");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando el motor naftero...");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando combustible al motor naftero...");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo el motor naftero...");
        }
    }
}
