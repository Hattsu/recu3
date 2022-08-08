// See https://aka.ms/new-console-template for more information
using System;
public class program{
   private void Main (string args ){
       
       Console.WriteLine("Taco");
       var tacos = new tacos();
       Console.WriteLine($"Precio del taco con chile seria: {tacos.CalcularTotalPrecio()}");
       var Conchile = new Conchile(tacos);
       Console.WriteLine($"Precio del taco sin chile seria: {tacos.CalcularTotalPrecio()}");
       var Sinchile = new Sinchile(tacos);
       Console.WriteLine($"Precio del taco con carne seria: {tacos.CalcularTotalPrecio()}");
       var Carne = new Carne(tacos);
       Console.WriteLine($"Precio del taco con pollo seria: {tacos.CalcularTotalPrecio()}");
       var pollo = new pollo(tacos);
       Console.WriteLine();


       Console.WriteLine("burritos");
       var burritos = new tacos();
       Console.WriteLine($"Precio del taco con chile seria: {tacos.CalcularTotalPrecio()}");
       var Conchile1 = new Conchile(burritos);
       Console.WriteLine($"Precio del taco sin chile seria: {tacos.CalcularTotalPrecio()}");
       var Sinchile2 = new Sinchile(burritos);
       Console.WriteLine($"Precio del taco con carne seria: {tacos.CalcularTotalPrecio()}");
       var Carne3 = new Carne(burritos);
       Console.WriteLine($"Precio del taco con pollo seria: {tacos.CalcularTotalPrecio()}");
       var pollo4 = new pollo(burritos);
       Console.WriteLine();

       Console.WriteLine("Tamales");
       var tamales = new tamales();
       Console.WriteLine($"Precio del taco con chile seria: {tacos.CalcularTotalPrecio()}");
       var Conchile5 = new Conchile(tamales);
       Console.WriteLine($"Precio del taco sin chile seria: {tacos.CalcularTotalPrecio()}");
       var Sinchile6 = new Sinchile(tamales);
       Console.WriteLine($"Precio del taco con carne seria: {tacos.CalcularTotalPrecio()}");
       var Carne7 = new Carne(tamales);
       Console.WriteLine($"Precio del taco con pollo seria: {tacos.CalcularTotalPrecio()}");
       var pollo8 = new pollo(tamales);
       Console.WriteLine();
       
   }
}