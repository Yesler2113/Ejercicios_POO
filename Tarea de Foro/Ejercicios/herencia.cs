using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Foro.Ejercicios
{
    public class herencia
    {
      
    }
    class Transporte
    {
        public string Nombre { get; set;}
        public String Marca {get; set;}

        public void Arrancar()
        {
            Console.WriteLine("EL medio de transporte esta arrancando.");

        }
    }

    class Avion : Transporte
    {
        public void Despegando()
        {
            Console.WriteLine("El avion ya despego.");
        }
    }

    class Carro : Transporte
    {
        public void Conducir()
        {
            Console.WriteLine("El carro ya va  corriendo. ");
        }
    }
}
