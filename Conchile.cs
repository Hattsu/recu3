using System;
public class Conchile:decorador{
    public Conchile(OrdenBase orden): base(orden){
        Console.WriteLine("");
    }
    public override double CalcularTotal()
    {
        return base.CalcularTotal()+0.45;
    }
}