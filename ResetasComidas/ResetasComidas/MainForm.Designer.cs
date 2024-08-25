namespace ResetasComidas
{
    partial class MainForm
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
            label1 = new Label();
            recetasListBox = new ListBox();
            verRecetaButton = new Button();
            agregarRecetaButton = new Button();
            eliminarRecetaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 25);
            label1.TabIndex = 0;
            label1.Text = "Recetas Disponibles";
            // 
            // recetasListBox
            // 
            recetasListBox.FormattingEnabled = true;
            recetasListBox.ItemHeight = 15;
            recetasListBox.Location = new Point(173, 91);
            recetasListBox.Name = "recetasListBox";
            recetasListBox.Size = new Size(420, 94);
            recetasListBox.TabIndex = 1;
            // 
            // verRecetaButton
            // 
            verRecetaButton.Location = new Point(173, 276);
            verRecetaButton.Name = "verRecetaButton";
            verRecetaButton.Size = new Size(121, 23);
            verRecetaButton.TabIndex = 2;
            verRecetaButton.Text = "Ver Receta";
            verRecetaButton.UseVisualStyleBackColor = true;
            verRecetaButton.Click += verRecetaButton_Click;
            // 
            // agregarRecetaButton
            // 
            agregarRecetaButton.Location = new Point(319, 276);
            agregarRecetaButton.Name = "agregarRecetaButton";
            agregarRecetaButton.Size = new Size(126, 23);
            agregarRecetaButton.TabIndex = 3;
            agregarRecetaButton.Text = "Agregar Receta";
            agregarRecetaButton.UseVisualStyleBackColor = true;
            agregarRecetaButton.Click += agregarRecetaButton_Click;
            // 
            // eliminarRecetaButton
            // 
            eliminarRecetaButton.Location = new Point(472, 276);
            eliminarRecetaButton.Name = "eliminarRecetaButton";
            eliminarRecetaButton.Size = new Size(121, 23);
            eliminarRecetaButton.TabIndex = 4;
            eliminarRecetaButton.Text = "Eliminar Receta";
            eliminarRecetaButton.UseVisualStyleBackColor = true;
            eliminarRecetaButton.Click += eliminarRecetaButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(eliminarRecetaButton);
            Controls.Add(agregarRecetaButton);
            Controls.Add(verRecetaButton);
            Controls.Add(recetasListBox);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox recetasListBox;
        private Button verRecetaButton;
        private Button agregarRecetaButton;
        private Button eliminarRecetaButton;
    }
}