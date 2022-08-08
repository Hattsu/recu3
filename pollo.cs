using System;
public class pollo:decorador{
    public pollo(OrdenBase orden): base(orden){
        Console.WriteLine("");
    }
    public override double CalcularTotal()
    {
        return base.CalcularTotal()+0.70;
    }
}