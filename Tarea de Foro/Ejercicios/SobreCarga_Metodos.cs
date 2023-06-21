using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_de_Foro.Ejercicios
{
    internal class SobreCarga_Metodos
    {
    }

    class Calculadora
    {
        public int sumar(int num1,  int num2)
        {
            return num1 + num2;
        }

        public double sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public int sumar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

    }
}
