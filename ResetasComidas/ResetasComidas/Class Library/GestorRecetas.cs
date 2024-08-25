using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResetasComidas.Class_Library
{
    public class GestorRecetas
    {
        private List<Receta> recetas;

        public GestorRecetas()
        {
            recetas = new List<Receta>();
        }

        public void AgregarReceta(Receta receta)
        {
            recetas.Add(receta);
        }

        public List<Receta> ObtenerRecetas()
        {
            return recetas;
        }
        public void EliminarReceta(int indice)
        {
            if (indice >= 0 && indice < recetas.Count)
            {
                recetas.RemoveAt(indice);
            }
        }
    }
}
