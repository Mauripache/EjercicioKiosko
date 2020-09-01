using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            ConversorDeMoneda conversor = new ConversorDeMoneda();
            Double pesos = conversor.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioTotal();
        }
    }
}