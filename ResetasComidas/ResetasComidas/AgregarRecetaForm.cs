using ResetasComidas.Class_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResetasComidas
{
    public partial class AgregarRecetaForm : Form
    {
        private GestorRecetas gestorRecetas;
        public AgregarRecetaForm(GestorRecetas gestorRecetas)
        {
            InitializeComponent();
            this.gestorRecetas = gestorRecetas;
        }

        private void agregarIngredienteButton_Click(object sender, EventArgs e)
        {
            string nombre = nombreIngredienteTextBox.Text;
            string unidad = unidadTextBox.Text;
            decimal cantidad;

            // Validar la cantidad ingresada
            if (!decimal.TryParse(cantidadTextBox.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            // Validar que la unidad no esté vacía
            if (string.IsNullOrEmpty(unidad))
            {
                MessageBox.Show("Ingrese una unidad válida.");
                return;
            }

            // Agregar el ingrediente a la lista
            ingredientesListBox.Items.Add($"{nombre} - {cantidad} {unidad}");

            // Limpiar campos de entrada
            nombreIngredienteTextBox.Clear();
            unidadTextBox.Clear();
            cantidadTextBox.Clear();
        }

        private void guardarRecetaButton_Click(object sender, EventArgs e)
        {
            string nombreReceta = nombreRecetaTextBox.Text;
            int porciones;

            // Validar los datos ingresados
            if (string.IsNullOrEmpty(nombreReceta) || !int.TryParse(porcionesTextBox.Text, out porciones) || porciones <= 0)
            {
                MessageBox.Show("Ingrese un nombre de receta y un número de porciones válido.");
                return;
            }

            // Crear la nueva receta
            Receta nuevaReceta = new Receta(nombreReceta, porciones, instruccionesTextBox.Text);

            // Agregar los ingredientes desde el ListBox a la receta
            foreach (var item in ingredientesListBox.Items)
            {
                string[] partes = item.ToString().Split('-');
                if (partes.Length < 2)
                {
                    MessageBox.Show("Formato de ingrediente inválido.");
                    return;
                }

                string nombre = partes[0].Trim();
                string[] cantidadUnidad = partes[1].Trim().Split(' ');

                if (cantidadUnidad.Length < 2)
                {
                    MessageBox.Show("Formato de cantidad o unidad inválido.");
                    return;
                }

                decimal cantidad;
                if (!decimal.TryParse(cantidadUnidad[0], out cantidad))
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }

                string unidad = cantidadUnidad[1];

                // Validar que la unidad no esté vacía
                if (string.IsNullOrEmpty(unidad))
                {
                    MessageBox.Show("Ingrese una unidad válida.");
                    return;
                }

                nuevaReceta.AgregarIngrediente(new Ingrediente(nombre, unidad, cantidad));
            }

            // Agregar receta al gestor y cerrar el formulario
            gestorRecetas.AgregarReceta(nuevaReceta);
            MessageBox.Show("Receta guardada con éxito.");
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
