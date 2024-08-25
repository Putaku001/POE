namespace ResetasComidas
{
    partial class AgregarRecetaForm
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
            nombreDeLaRecetaLabel = new Label();
            porcionesLabel = new Label();
            instruccionesLabel = new Label();
            nombreDelIngredienteLabel = new Label();
            cantidadLabel = new Label();
            UnidadLabel = new Label();
            nombreRecetaTextBox = new TextBox();
            porcionesTextBox = new TextBox();
            instruccionesTextBox = new TextBox();
            nombreIngredienteTextBox = new TextBox();
            cantidadTextBox = new TextBox();
            unidadTextBox = new TextBox();
            ingredientesListBox = new ListBox();
            guardarRecetaButton = new Button();
            cancelarButton = new Button();
            agregarIngredienteButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // nombreDeLaRecetaLabel
            // 
            nombreDeLaRecetaLabel.AutoSize = true;
            nombreDeLaRecetaLabel.Location = new Point(41, 79);
            nombreDeLaRecetaLabel.Name = "nombreDeLaRecetaLabel";
            nombreDeLaRecetaLabel.Size = new Size(117, 15);
            nombreDeLaRecetaLabel.TabIndex = 0;
            nombreDeLaRecetaLabel.Text = "Nombre de la Receta";
            // 
            // porcionesLabel
            // 
            porcionesLabel.AutoSize = true;
            porcionesLabel.Location = new Point(41, 118);
            porcionesLabel.Name = "porcionesLabel";
            porcionesLabel.Size = new Size(59, 15);
            porcionesLabel.TabIndex = 1;
            porcionesLabel.Text = "Porciones";
            // 
            // instruccionesLabel
            // 
            instruccionesLabel.AutoSize = true;
            instruccionesLabel.Location = new Point(41, 163);
            instruccionesLabel.Name = "instruccionesLabel";
            instruccionesLabel.Size = new Size(77, 15);
            instruccionesLabel.TabIndex = 2;
            instruccionesLabel.Text = "Instrucciones";
            // 
            // nombreDelIngredienteLabel
            // 
            nombreDelIngredienteLabel.AutoSize = true;
            nombreDelIngredienteLabel.Location = new Point(41, 222);
            nombreDelIngredienteLabel.Name = "nombreDelIngredienteLabel";
            nombreDelIngredienteLabel.Size = new Size(133, 15);
            nombreDelIngredienteLabel.TabIndex = 3;
            nombreDelIngredienteLabel.Text = "Nombre del Ingrediente";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new Point(41, 269);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new Size(55, 15);
            cantidadLabel.TabIndex = 4;
            cantidadLabel.Text = "Cantidad";
            // 
            // UnidadLabel
            // 
            UnidadLabel.AutoSize = true;
            UnidadLabel.Location = new Point(41, 320);
            UnidadLabel.Name = "UnidadLabel";
            UnidadLabel.Size = new Size(45, 15);
            UnidadLabel.TabIndex = 5;
            UnidadLabel.Text = "Unidad";
            // 
            // nombreRecetaTextBox
            // 
            nombreRecetaTextBox.Location = new Point(164, 76);
            nombreRecetaTextBox.Name = "nombreRecetaTextBox";
            nombreRecetaTextBox.Size = new Size(191, 23);
            nombreRecetaTextBox.TabIndex = 6;
            // 
            // porcionesTextBox
            // 
            porcionesTextBox.Location = new Point(164, 117);
            porcionesTextBox.Name = "porcionesTextBox";
            porcionesTextBox.Size = new Size(191, 23);
            porcionesTextBox.TabIndex = 7;
            // 
            // instruccionesTextBox
            // 
            instruccionesTextBox.Location = new Point(164, 160);
            instruccionesTextBox.Name = "instruccionesTextBox";
            instruccionesTextBox.Size = new Size(191, 23);
            instruccionesTextBox.TabIndex = 8;
            // 
            // nombreIngredienteTextBox
            // 
            nombreIngredienteTextBox.Location = new Point(180, 218);
            nombreIngredienteTextBox.Name = "nombreIngredienteTextBox";
            nombreIngredienteTextBox.Size = new Size(175, 23);
            nombreIngredienteTextBox.TabIndex = 9;
            // 
            // cantidadTextBox
            // 
            cantidadTextBox.Location = new Point(164, 268);
            cantidadTextBox.Name = "cantidadTextBox";
            cantidadTextBox.Size = new Size(191, 23);
            cantidadTextBox.TabIndex = 10;
            // 
            // unidadTextBox
            // 
            unidadTextBox.Location = new Point(164, 313);
            unidadTextBox.Name = "unidadTextBox";
            unidadTextBox.Size = new Size(191, 23);
            unidadTextBox.TabIndex = 11;
            // 
            // ingredientesListBox
            // 
            ingredientesListBox.FormattingEnabled = true;
            ingredientesListBox.ItemHeight = 15;
            ingredientesListBox.Location = new Point(450, 76);
            ingredientesListBox.Name = "ingredientesListBox";
            ingredientesListBox.Size = new Size(287, 139);
            ingredientesListBox.TabIndex = 12;
            // 
            // guardarRecetaButton
            // 
            guardarRecetaButton.Location = new Point(459, 359);
            guardarRecetaButton.Name = "guardarRecetaButton";
            guardarRecetaButton.Size = new Size(119, 23);
            guardarRecetaButton.TabIndex = 13;
            guardarRecetaButton.Text = "Guardar Receta";
            guardarRecetaButton.UseVisualStyleBackColor = true;
            guardarRecetaButton.Click += guardarRecetaButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(593, 359);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(119, 23);
            cancelarButton.TabIndex = 14;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // agregarIngredienteButton
            // 
            agregarIngredienteButton.Location = new Point(135, 369);
            agregarIngredienteButton.Name = "agregarIngredienteButton";
            agregarIngredienteButton.RightToLeft = RightToLeft.Yes;
            agregarIngredienteButton.Size = new Size(149, 23);
            agregarIngredienteButton.TabIndex = 15;
            agregarIngredienteButton.Text = "Agregar un Ingrediente";
            agregarIngredienteButton.UseVisualStyleBackColor = true;
            agregarIngredienteButton.Click += agregarIngredienteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 16;
            label1.Text = "Agregar Receta";
            // 
            // AgregarRecetaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(agregarIngredienteButton);
            Controls.Add(cancelarButton);
            Controls.Add(guardarRecetaButton);
            Controls.Add(ingredientesListBox);
            Controls.Add(unidadTextBox);
            Controls.Add(cantidadTextBox);
            Controls.Add(nombreIngredienteTextBox);
            Controls.Add(instruccionesTextBox);
            Controls.Add(porcionesTextBox);
            Controls.Add(nombreRecetaTextBox);
            Controls.Add(UnidadLabel);
            Controls.Add(cantidadLabel);
            Controls.Add(nombreDelIngredienteLabel);
            Controls.Add(instruccionesLabel);
            Controls.Add(porcionesLabel);
            Controls.Add(nombreDeLaRecetaLabel);
            Name = "AgregarRecetaForm";
            Text = "AgregarRecetaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreDeLaRecetaLabel;
        private Label porcionesLabel;
        private Label instruccionesLabel;
        private Label nombreDelIngredienteLabel;
        private Label cantidadLabel;
        private Label UnidadLabel;
        private TextBox nombreRecetaTextBox;
        private TextBox porcionesTextBox;
        private TextBox instruccionesTextBox;
        private TextBox nombreIngredienteTextBox;
        private TextBox cantidadTextBox;
        private TextBox unidadTextBox;
        private ListBox ingredientesListBox;
        private Button guardarRecetaButton;
        private Button cancelarButton;
        private Button agregarIngredienteButton;
        private Label label1;
    }
}