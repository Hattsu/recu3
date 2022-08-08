using System;
public class Carne:decorador{
    public Carne(OrdenBase orden): base(orden){
        Console.WriteLine("");
    }
    public override double CalcularTotal()
    {
        return base.CalcularTotal()+0.60;
    }
}