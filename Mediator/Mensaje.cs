using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Chat
{
    public class Mensaje 
    {
        private DateTime _fecha;

        public Mensaje()
        {
            _fecha = DateTime.Now;
        }
        public Usuario De { get; set; }
        public Usuario Para { get; set; }
        public string Texto { get; set; }

        public DateTime Fecha { get { return _fecha; } }

        public override string ToString()
        {
            return $"Mensaje a las {Fecha.ToShortTimeString()} de {De} para {Para} --> {Texto}";
        }
    }
}
