using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CafeDescafeinado : BebidaComponent
    {
        public override double Costo => 850;
        public override string Descripcion => "Café descafeinado";
    }
}
