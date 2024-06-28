using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Text.Json;

namespace GenericosEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //se crea un objeto de la clase Lista y se ingresan STRINGS
            var listaStrings = new Lista<string>(4);
            RellenarLista(listaStrings, "Jean", "Baptiste", "Emmanuel", "Zorg");
            MostrarLista(listaStrings, "STRINGS");

            //se crea un objeto de la clase Lista y se ingresan ENTEROS
            var listaEnteros = new Lista<int>(3);
            RellenarLista(listaEnteros, 2, 4, 6, 8); //el último elemento no debe entrar
            MostrarLista(listaEnteros, "ENTEROS");

            //se crea un objeto de la clase Lista y se ingresan OBJETOS DE JUGADORES
            var listaObjJugadores = new Lista<Jugadores>(4);
            RellenarLista(listaObjJugadores, new Jugadores("Messi", 37), new Jugadores("Ronaldo", 39), new Jugadores("Zlatan", 42), new Jugadores("Ozil", 35));
            MostrarLista(listaObjJugadores, "OBJETO JUGADORES");

            Nada();
            //evita que la consola se cierre
            Console.ReadKey();
        }

        private static void Serie()
        {

        }

        //refactorizando código         refactorizando código
        private static void RellenarLista<T>(Lista<T> listaGenerica, params T [] elementos)
        {
            //método común para rellenar objetos de la clase Lista
            foreach (var elemento in elementos)
            {
                listaGenerica.Anhadir(elemento);
            }
        }

        private static void MostrarLista<T>(Lista<T> listaGenerica, string textoGenerico)
        {
            //método común para mostra los objetos de la clase Lista
            string miCadena = listaGenerica.Mostrar();
            Console.WriteLine($"\n@@@{textoGenerico}: {miCadena}");
        }

        private static void Nada()
        {
            var miJugador = new Jugadores("Messi", 37);
            string miString = JsonSerializer.Serialize(miJugador);
            Console.WriteLine("JSON: " + miString);
            var miObjeto = JsonSerializer.Deserialize<Jugadores>(miString);
            Console.WriteLine("OBjeto " + miObjeto._nombre);
        }
    }
}
