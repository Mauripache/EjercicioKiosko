using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca altaBiblioteca = new Biblioteca("ALTA BIBLIOTECA");
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            altaBiblioteca.AlmacenarLibro(libro1,"A","7");
            altaBiblioteca.AlmacenarLibro(libro2,"B","3");
        }
    }
}
