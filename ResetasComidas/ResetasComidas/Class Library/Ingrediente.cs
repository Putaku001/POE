using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetasComidas.Class_Library
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public string Unidad { get; set; }
        public decimal Cantidad { get; set; }

        public Ingrediente(string nombre, string unidad, decimal cantidad)
        {
            Nombre = nombre;
            Unidad = unidad;
            Cantidad = cantidad;
        }
    }
}
