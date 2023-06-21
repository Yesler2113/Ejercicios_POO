// See https://aka.ms/new-console-template for more information
using Tarea_de_Foro.Ejercicios;

//Avion avion = new Avion();
//avion.Nombre = "Avion";
//avion.Marca = "Spirit";
//Console.WriteLine("Nombre del transporte: " + avion.Nombre);
//Console.WriteLine("Marca: "+ avion.Marca);
//avion.Arrancar();
//avion.Despegando();
//Console.WriteLine();

//Carro micarro = new Carro();
//micarro.Nombre = "Carro";
//micarro.Marca = "Toyota.";
//Console.WriteLine("Nombre del Transporte: " + micarro.Nombre);
//Console.WriteLine("Marca: " + micarro.Marca);
//micarro.Arrancar();
//micarro.Conducir();
//Console.WriteLine();    

//Moto moto = new Moto();
//moto.Nombre = "Motocicleta";
//moto.Marca = "YAMAHA";
//Console.WriteLine("Nombre del Transporte: " +  moto.Nombre);
//Console.WriteLine("Marca: "+  moto.Marca);
//moto.Arrancar();
//moto.Empezar();

//Console.WriteLine();    

//Calculadora calculadora = new Calculadora();

//int resultado1 = calculadora.sumar(5, 6);
//Console.WriteLine("El resultado de la suma es: " +  resultado1);
//double resultado2 = calculadora.sumar(2.4, 4.7);
//Console.WriteLine("El resultado de la suma es: " +  (double)resultado2);
//int resultado3 = calculadora.sumar(67, 78, 89);
//Console.WriteLine("El resultado de la suma es: " + resultado3);

Vehiculo auto = new Vehiculo("Toyota", "Hilux");
auto.Informacion();
Console.WriteLine();

Motocicleta m = new Motocicleta("Yamaha", "YBR125", "Deportiva");
m.Informacion();

Console.ReadLine();