using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Edulcorante : AgregadoDecorator
    {
        public Edulcorante(BebidaComponent bebida) : base(bebida) { }
        public override double Costo => _bebida.Costo + 20;
        public override string Descripcion => $"{_bebida.Descripcion}, Edulcorante";

        //public override string Descripcion
        //{
        //    get { return $"{_bebida.Descripcion}, Edulcorante"; }
        //}
    }
}
