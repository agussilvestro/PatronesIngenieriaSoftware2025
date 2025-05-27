using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;

        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }
        public bool MoveNext()
        {
            posicion++;
            if (posicion < arreglo.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            posicion = -1;
        }
    }
}
