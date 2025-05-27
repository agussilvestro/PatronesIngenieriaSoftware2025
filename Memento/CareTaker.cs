using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CareTaker
    {
        private List<Memento> _mementos = new List<Memento>();

        public void Add(Memento m)
        {
            _mementos.Add(m);
        }

        public Memento GetMemento(int index)
        {
            return _mementos[index];
        }
    }
}
