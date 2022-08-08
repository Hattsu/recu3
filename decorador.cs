using System;
public class decorador:OrdenBase{
    protected OrdenBase orden;
    public decorador(OrdenBase orden){
        this.orden = orden;
    }
    public virtual double CalcularTotal(){
        Console.WriteLine("Precio Calcular desde decorador");
        return orden.CalcularTotalPrecio();
    }
    
}