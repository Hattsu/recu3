using System;
public class Sinchile:decorador{
    public Sinchile(OrdenBase orden): base(orden){
        Console.WriteLine("");
    }
    public override double CalcularTotal()
    {
        return base.CalcularTotal()+0.50;
    }
}