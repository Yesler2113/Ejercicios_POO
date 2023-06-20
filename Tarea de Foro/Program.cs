// See https://aka.ms/new-console-template for more information
using Tarea_de_Foro.Ejercicios;

Avion avion = new Avion();
avion.Nombre = "Avion";
avion.Marca = "Spirit";
Console.WriteLine("Nombre del transporte: " + avion.Nombre);
Console.WriteLine("Marca: "+ avion.Marca);
avion.Arrancar();
avion.Despegando();



Console.WriteLine();

Carro micarro = new Carro();
micarro.Nombre = "Carro";
micarro.Marca = "Toyota.";
Console.WriteLine("Nombre del Transporte: " + micarro.Nombre);
Console.WriteLine("Marca: " + micarro.Marca);
micarro.Arrancar();
micarro.Conducir();
