using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetasComidas.Class_Library
{
    public class Receta
    {
        public string Nombre { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public string Instrucciones { get; set; }
        public int Porciones { get; set; }

        public Receta(string nombre, int porciones, string instrucciones)
        {
            Nombre = nombre;
            Porciones = porciones;
            Instrucciones = instrucciones;
            Ingredientes = new List<Ingrediente>();
        }

        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }

        public List<Ingrediente> CalcularIngredientes(int nuevasPorciones)
        {
            List<Ingrediente> ingredientesCalculados = new List<Ingrediente>();
            decimal factor = (decimal)nuevasPorciones / Porciones;

            foreach (var ingrediente in Ingredientes)
            {
                ingredientesCalculados.Add(new Ingrediente(ingrediente.Nombre, ingrediente.Unidad, ingrediente.Cantidad * factor));
            }

            return ingredientesCalculados;
        }
    }
}
