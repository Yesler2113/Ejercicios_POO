using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Foro.Ejercicios
{
    class Vehiculo
    {
        private string marca;
        private string modelo;

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public void Informacion()
        {
            Console.WriteLine($"Marca del Vehiculo:{marca}");
            Console.WriteLine($"Modelo del Vehiculo: {modelo}");
        }
    }
    class Automovil : Vehiculo
    {
        private int motor;

        public Automovil(string marca, string modelo, int motor) : base(marca, modelo) 
        {
            this.motor = motor;
        }
        public int Motor
        {
            get {return  motor;}
            set { motor = value;}
        }
        public void Informacion()
        {
            base.Informacion();
            Console.WriteLine($"Tipo de motor: {motor}");
        }
    }
    class Motocicleta : Vehiculo
    {
        private string tipo;

        public Motocicleta(string marca, string modelo, string tipo) : base(marca, modelo)
        {
            this.tipo = tipo;
        }
        public string Tipo
        {
            get { return tipo;}
            set { tipo = value; }
        }

        public void Informacion()
        {
            base.Informacion();
            Console.WriteLine($"Tipo: {tipo}");
        }
    }
}
