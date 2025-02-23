using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsola
{
    internal class Persona
    {
        // atributos o propiedades o caracteristicas
        public string nombre;
        public int edad;

        // constructor
        public Persona()
        {
            nombre = "Cristian";
            edad = 29;
        }
        // metodo
        public void Mensaje()
        {
            Console.WriteLine($"nombre: {nombre}, edad: {edad}");
        }

        
    }
}
