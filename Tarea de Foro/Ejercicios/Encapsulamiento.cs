using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Foro.Ejercicios
{
    internal class Encapsulamiento
    {
    }

    public class Carro2
    {
        private string modelo;
        private string marca;
        private int año;
        private bool encendido;

        public string Modelo
        {
            get { return modelo; }
            set {modelo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Año
        {
            get {return año; }
            set {año =value;}
        }
        public bool Encendido
        {
            get { return encendido; }
        }
        public void ArrancarCarro()
        {
            if (!Encendido)
            {
                encendido = true;
                Console.WriteLine("El carro esta encendido.");
            }
            else
            {
                Console.WriteLine("El carro ha arrancado.");
            }

        }
        public void Frenar()
        {
            if (Encendido)
            {
                encendido=false;
                Console.WriteLine("El carro ha frenado.");
            }
            else
            {
                Console.WriteLine("El carro ya esta detenido.");
            }
        }
    }

}
