using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Canela : AgregadoDecorator
    {
        public Canela(BebidaComponent bebida) : base(bebida) { }
        public override double Costo => _bebida.Costo + 175;
        public override string Descripcion => $"{_bebida.Descripcion}, Canela";

        //public override string Descripcion
        //{
        //    get { return $"{_bebida.Descripcion}, Canela"; }
        //}
    }
}
