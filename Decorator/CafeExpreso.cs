using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CafeExpreso : BebidaComponent
    {
        public override double Costo => 680;
        public override string Descripcion => "Café expreso";
    }
}
