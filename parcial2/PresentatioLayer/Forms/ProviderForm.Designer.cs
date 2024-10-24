namespace PresentatioLayer.Forms
{
    partial class ProviderForm
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
            label2 = new Label();
            label3 = new Label();
            providerDataGridView = new DataGridView();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            saveButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            phoneComboBox = new ComboBox();
            phoneButton = new Button();
            ((System.ComponentModel.ISupportInitialize)providerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 154);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 257);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 380);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // providerDataGridView
            // 
            providerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            providerDataGridView.Location = new Point(723, 129);
            providerDataGridView.Name = "providerDataGridView";
            providerDataGridView.RowHeadersWidth = 82;
            providerDataGridView.Size = new Size(493, 300);
            providerDataGridView.TabIndex = 3;
            providerDataGridView.SelectionChanged += providerDataGridView_SelectionChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(253, 151);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(381, 39);
            nameTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(253, 260);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(381, 39);
            emailTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(132, 548);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 6;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(324, 548);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 7;
            editButton.Text = "editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(525, 548);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 8;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // phoneComboBox
            // 
            phoneComboBox.FormattingEnabled = true;
            phoneComboBox.Location = new Point(253, 383);
            phoneComboBox.Name = "phoneComboBox";
            phoneComboBox.Size = new Size(381, 40);
            phoneComboBox.TabIndex = 9;
            // 
            // phoneButton
            // 
            phoneButton.Location = new Point(134, 631);
            phoneButton.Name = "phoneButton";
            phoneButton.Size = new Size(541, 46);
            phoneButton.TabIndex = 10;
            phoneButton.Text = "Agregar Celular";
            phoneButton.UseVisualStyleBackColor = true;
            phoneButton.Click += phoneButton_Click;
            // 
            // ProviderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 795);
            Controls.Add(phoneButton);
            Controls.Add(phoneComboBox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(saveButton);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(providerDataGridView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProviderForm";
            Text = "ProviderForm";
            ((System.ComponentModel.ISupportInitialize)providerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView providerDataGridView;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private Button saveButton;
        private Button editButton;
        private Button deleteButton;
        private ComboBox phoneComboBox;
        private Button phoneButton;
    }
}