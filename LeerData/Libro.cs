using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeerData
{
    //1
    public class Libro
    {
        //Cargo propiedades
        public int LibroID {get;set;}
        public string Titulo {get;set;}
        public string Descripcion {get; set;}
        public System.DateTime FechaPublicacion {get;set;}
//Anclaje 1 a 1
        public Precio PrecioPromocion {get;set;}
//Anclaje 1 a *. Lado 1
        //Represente la coleccion de comentario de la clase libro
        //Para usar ICollection hay que importar la libreria using System.Collections.Generic;
        public ICollection<Comentario> ComentarioLista {get;set;}
//Anclaje de * a *. Lado entre LibroAutor Autor
        public ICollection<LibroAutor> AutorLink {get;set;}
    }
}