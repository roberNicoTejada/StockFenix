//3 Program.cs
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSERTAR DATA///////////////////////////////////
            using (var db = new AppVentaLibrosContext())
            {
                //Single hace una busqueda
                var autor = db.Autor.Single(x => x.Nombre == "Paola");
                if (autor != null)
                {
                    autor.Apellidos = "Mendez";
                    autor.Grado = "Biologo";
                    var estadoTransaccion = db.SaveChanges();
                    Console.WriteLine("Estado de transaccion ==> " + estadoTransaccion);
                }
            }
        }
    }
}