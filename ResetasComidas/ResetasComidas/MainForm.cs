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
    public partial class MainForm : Form
    {
        private GestorRecetas gestorRecetas;
        public MainForm()
        {
            InitializeComponent();
            gestorRecetas = new GestorRecetas();
            CargarRecetasIniciales();
            ActualizarListaRecetas();
        }
        private void CargarRecetasIniciales()
        {
            Receta receta = new Receta("Ensalada César", 4, "1. Mezclar ingredientes.\n2. Servir.");
            receta.AgregarIngrediente(new Ingrediente("Lechuga", "", 2));
            receta.AgregarIngrediente(new Ingrediente("Crutones", "tazas", 1));
            receta.AgregarIngrediente(new Ingrediente("Queso parmesano", "gramos", 50));
            gestorRecetas.AgregarReceta(receta);
        }
        private void ActualizarListaRecetas()
        {
            recetasListBox.Items.Clear();
            foreach (var receta in gestorRecetas.ObtenerRecetas())
            {
                recetasListBox.Items.Add(receta.Nombre);
            }
        }

        private void verRecetaButton_Click(object sender, EventArgs e)
        {
            if (recetasListBox.SelectedIndex != -1)
            {
                var recetaSeleccionada = gestorRecetas.ObtenerRecetas()[recetasListBox.SelectedIndex];
                ResultadosForm resultadosForm = new ResultadosForm(recetaSeleccionada);
                resultadosForm.ShowDialog();
            }
        }

        private void agregarRecetaButton_Click(object sender, EventArgs e)
        {
            AgregarRecetaForm agregarRecetaForm = new AgregarRecetaForm(gestorRecetas);
            agregarRecetaForm.ShowDialog();
            ActualizarListaRecetas();
        }

        private void eliminarRecetaButton_Click(object sender, EventArgs e)
        {
            if (recetasListBox.SelectedIndex != -1)
            {
                
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar esta receta?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmacion == DialogResult.Yes)
                {
                 
                    gestorRecetas.EliminarReceta(recetasListBox.SelectedIndex);
                    ActualizarListaRecetas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una receta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
