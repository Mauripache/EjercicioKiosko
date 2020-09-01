using System;

namespace Expert_SRP
{
    /*
        En esta clase es donde calcularía el precio total ya que es la experta
        en datos (contiene precioDulce y precioMasa).
    */
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}