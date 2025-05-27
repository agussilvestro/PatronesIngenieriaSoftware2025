using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class CContenedora : IEnumerable
    {
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int i = 0; i < 10; i++)
            {
                valores[i] = i * i;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return (new ContenedorEnum(valores));
        }
    }
}
