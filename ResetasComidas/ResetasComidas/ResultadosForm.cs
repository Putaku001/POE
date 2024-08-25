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
    public partial class ResultadosForm : Form
    {
        private Receta receta;
        public ResultadosForm(Receta receta)
        {
            InitializeComponent();
            this.receta = receta;
            MostrarReceta();
        }
        private void MostrarReceta()
        {
            nombreLabel.Text = receta.Nombre;

            instrruccionesResultadoLabel.Text = receta.Instrucciones;

            ingredientesListBox.Items.Clear();
            foreach (var ingrediente in receta.Ingredientes)
            {
                ingredientesListBox.Items.Add($"{ingrediente.Nombre} - {ingrediente.Cantidad} {ingrediente.Unidad}");
            }
        }

        private void recalcularButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(porcionesTextBox.Text, out int nuevasPorciones) && nuevasPorciones > 0)
            {
                var nuevosIngredientes = receta.CalcularIngredientes(nuevasPorciones);
                ingredientesListBox.Items.Clear();
                foreach (var ingrediente in nuevosIngredientes)
                {
                    ingredientesListBox.Items.Add($"{ingrediente.Nombre} - {ingrediente.Cantidad} {ingrediente.Unidad}");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número de porciones válido.");
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
