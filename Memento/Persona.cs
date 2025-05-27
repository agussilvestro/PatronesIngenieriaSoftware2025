using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Persona
    {
        public string Nombre { get; set; }

        public Memento saveToMemento()
        {
            Console.WriteLine("Originator: Guardando memento para " + Nombre);
            return new Memento(Nombre);
        }

        public void restoreToMemento(Memento m)
        {
            Nombre = m.Estado;
            Console.WriteLine("Originator: Recuperando memento " + Nombre);
        }
    }
}
