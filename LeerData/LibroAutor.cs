using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    public class LibroAutor
    {
        public int AutorId {get;set;}
        public int LibroId {get;set;}
//Anclaje LibroAutor Libro
        public Libro Libro {get;set;}
        public Autor Autor {get;set;}
    }
}