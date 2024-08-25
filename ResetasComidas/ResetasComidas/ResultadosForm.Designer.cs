namespace ResetasComidas
{
    partial class ResultadosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nombreLabel = new Label();
            porcionesLabel = new Label();
            porcionesTextBox = new TextBox();
            ingredientesListBox = new ListBox();
            IngredientesLabel = new Label();
            recalcularButton = new Button();
            cancelarButton = new Button();
            instruccionesLabel = new Label();
            nombreRecetaLabel = new Label();
            tituloLabel = new Label();
            instrruccionesResultadoLabel = new Label();
            SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(348, 46);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(0, 15);
            nombreLabel.TabIndex = 0;
            // 
            // porcionesLabel
            // 
            porcionesLabel.AutoSize = true;
            porcionesLabel.Location = new Point(233, 94);
            porcionesLabel.Name = "porcionesLabel";
            porcionesLabel.Size = new Size(59, 15);
            porcionesLabel.TabIndex = 1;
            porcionesLabel.Text = "Porciones";
            // 
            // porcionesTextBox
            // 
            porcionesTextBox.Location = new Point(300, 93);
            porcionesTextBox.Name = "porcionesTextBox";
            porcionesTextBox.Size = new Size(186, 23);
            porcionesTextBox.TabIndex = 2;
            // 
            // ingredientesListBox
            // 
            ingredientesListBox.FormattingEnabled = true;
            ingredientesListBox.ItemHeight = 15;
            ingredientesListBox.Location = new Point(233, 160);
            ingredientesListBox.Name = "ingredientesListBox";
            ingredientesListBox.Size = new Size(285, 94);
            ingredientesListBox.TabIndex = 3;
            // 
            // IngredientesLabel
            // 
            IngredientesLabel.AutoSize = true;
            IngredientesLabel.Location = new Point(233, 142);
            IngredientesLabel.Name = "IngredientesLabel";
            IngredientesLabel.Size = new Size(72, 15);
            IngredientesLabel.TabIndex = 4;
            IngredientesLabel.Text = "Ingredientes";
            // 
            // recalcularButton
            // 
            recalcularButton.Location = new Point(233, 375);
            recalcularButton.Name = "recalcularButton";
            recalcularButton.Size = new Size(109, 23);
            recalcularButton.TabIndex = 6;
            recalcularButton.Text = "Recalcular";
            recalcularButton.UseVisualStyleBackColor = true;
            recalcularButton.Click += recalcularButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(409, 375);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(109, 23);
            cancelarButton.TabIndex = 7;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // instruccionesLabel
            // 
            instruccionesLabel.AutoSize = true;
            instruccionesLabel.Location = new Point(233, 274);
            instruccionesLabel.Name = "instruccionesLabel";
            instruccionesLabel.Size = new Size(77, 15);
            instruccionesLabel.TabIndex = 8;
            instruccionesLabel.Text = "Instrucciones";
            // 
            // nombreRecetaLabel
            // 
            nombreRecetaLabel.AutoSize = true;
            nombreRecetaLabel.Location = new Point(291, 46);
            nombreRecetaLabel.Name = "nombreRecetaLabel";
            nombreRecetaLabel.Size = new Size(51, 15);
            nombreRecetaLabel.TabIndex = 9;
            nombreRecetaLabel.Text = "Nombre";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(348, 9);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(67, 25);
            tituloLabel.TabIndex = 10;
            tituloLabel.Text = "Receta";
            // 
            // instrruccionesResultadoLabel
            // 
            instrruccionesResultadoLabel.AutoSize = true;
            instrruccionesResultadoLabel.Location = new Point(314, 275);
            instrruccionesResultadoLabel.Name = "instrruccionesResultadoLabel";
            instrruccionesResultadoLabel.Size = new Size(0, 15);
            instrruccionesResultadoLabel.TabIndex = 11;
            // 
            // ResultadosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(instrruccionesResultadoLabel);
            Controls.Add(tituloLabel);
            Controls.Add(nombreRecetaLabel);
            Controls.Add(instruccionesLabel);
            Controls.Add(cancelarButton);
            Controls.Add(recalcularButton);
            Controls.Add(IngredientesLabel);
            Controls.Add(ingredientesListBox);
            Controls.Add(porcionesTextBox);
            Controls.Add(porcionesLabel);
            Controls.Add(nombreLabel);
            Name = "ResultadosForm";
            Text = "ResultadosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreLabel;
        private Label porcionesLabel;
        private TextBox porcionesTextBox;
        private ListBox ingredientesListBox;
        private Label IngredientesLabel;
        private Button recalcularButton;
        private Button cancelarButton;
        private Label instruccionesLabel;
        private Label nombreRecetaLabel;
        private Label tituloLabel;
        private Label instrruccionesResultadoLabel;
    }
}