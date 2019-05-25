using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Articulo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }

        public Articulo()
        {
        }

        public Articulo(int codigo, string descripcion, float precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
        }
    }

}