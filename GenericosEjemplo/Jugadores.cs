using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GenericosEjemplo
{
    internal class Jugadores
    {
        //variables de clase
        public string _nombre { get; set; }
        public int _edad{ get; set; }

        internal Jugadores(string nombre, int edad)
        {
            //se inicializan las variables de clase
            _nombre = nombre;
            _edad = edad;
        }

        public Jugadores()
        {
        }

        public override string ToString()
        {
            //se ocupa sobreescribir ToString() para mostrar los resultados
            return $"El nombre del jugador es {_nombre} y su edad es de {_edad} años";
        }
    }
}
