using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosEjemplo
{
    internal class Lista<T>
    {
        //variables de clase
        private int _dimension { get; set; }
        private List<T> _miLista { get; set; }

        internal Lista(int dimension)
        {
            //se inicializan las variables de clase
            _dimension = dimension;
            _miLista = new List<T>(_dimension);
        }

        internal void Anhadir(T elemento)
        {
            //se asegura de ingresar solo la cantidad determinada de elementos
            if (_miLista.Count < _dimension)
            {
                _miLista.Add(elemento);
            }
        }

        internal string Mostrar()
        {
            string miCadena = "\n";
            for (int i = 0; i < _miLista.Count; i++)
            {
                //se obtiene elemento por elemento
                miCadena += _miLista[i];
                if (i + 1 < _miLista.Count)
                {
                    //para dar "formato"
                    miCadena += ", \n";
                }
            }
            return miCadena;
        }
    }
}
