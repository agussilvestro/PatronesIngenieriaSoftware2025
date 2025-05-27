using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MotorElectrico
    {
        private bool _conectado;
        private bool _activo;
        private bool _moviendo;

        public void Conectar()
        {
            if (_conectado) 
            { 
                Console.WriteLine("¡Imposible conectar un motor electrico ya conectado!");
            }
            else
            {
                _conectado = true;
                Console.WriteLine("¡Motor conectado!");
            }
        }

        public void Activar()
        {
            if (!_conectado)
            { 
                Console.WriteLine("Imposible activar un motor no conectado");
            }
            else
            {
                _activo = true;
                Console.WriteLine("¡Motor activado!");
            }
        }

        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehiculo con motor eléctrico...");
            }
            else
            {
                Console.WriteLine("El motor deberá estar conectado y activo!");
            }

        }

        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehiculo con motor eléctrico...");
            }
            else
            {
                Console.WriteLine("Imposible parar un motor que no esté en movimiento!");
            }
        }

        public void Desconectar()
        {
            if (_conectado)
            {
                Console.WriteLine("Motor desconectado");
            }
            else
            {
                Console.WriteLine("Imposible desconectar un motor que no esté conectado!");
            }
        }

        public void Desactivar()
        {
            if (_activo)
            {
                _activo = false;
                Console.WriteLine("Motor desactivado");
            }
            else
            {
                Console.WriteLine("Imposible desactivar un motor que no esté activo!");
            }
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo = false;
                Console.WriteLine("¡Motor cargando las baterias!");
            }
            else
            {
                Console.WriteLine("Imposible enchufar un motor activo!");
            }
        }
    }
}
