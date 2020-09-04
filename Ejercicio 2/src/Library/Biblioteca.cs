using System;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca
    {
        public List<Libro> Libros {get; set;}
        public string Nombre {get; set;}
        public Biblioteca(string nombre)
        {
            this.Nombre = nombre;
            this.Libros = new List<Libro>();
        }

        public void AlmacenarLibro(Libro nuevoLibro, String sector, String estante)
        {
            nuevoLibro.EstanteBiblioteca = estante;
            nuevoLibro.SectorBiblioteca = sector;
            this.Libros.Add(nuevoLibro);
        }

    }
}