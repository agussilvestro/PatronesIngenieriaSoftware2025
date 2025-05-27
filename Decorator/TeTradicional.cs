using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TeTradicional : BebidaComponent
    {
        public override double Costo => 350;
        public override string Descripcion => "Té tradicional";
    }
}
