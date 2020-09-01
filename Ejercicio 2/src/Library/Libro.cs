using System;

namespace SRP
{
    /*
        No se cumple el SRP ya que la clase Libro es responsable de conocer los datos del libro, pero además
        de conocer el estante en que se encuentra y el sector de la biblioteca. Separaría en una clase a parte
        llama Biblioteca que contiene una lista de objetos de una clase llamada Sector que contiene una lista 
        de objetos de la clase Estante y la clase estante a su vez tendría
        una lista de objetos de clase Libro.
    */
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
