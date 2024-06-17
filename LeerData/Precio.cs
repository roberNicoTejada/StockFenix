using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class Precio
    {
        public int PrecioId {get;set;}
        public decimal PrecioActual {get;set;}
        public decimal Promocion {get;set;}
        //FK
        public int LibroId {get;set;}
        //Anclaje para la relacion de 1 a 1
        public Libro Libro {get;set;}
    }
}