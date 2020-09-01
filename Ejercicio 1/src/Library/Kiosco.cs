using System;

namespace Expert_SRP
{
    /*
        No cumple el patrón expert ya que se hace la cuenta del valor total 
        del alfajor desde la clase Kiosco cuando la que tiene esos datos es alfajor.
        ConvertirAPesos debería estar en otra clase por si se quiere cambiar o agregar diferentes
        monedas.
    */
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}