namespace PresentatioLayer.Forms
{
    partial class PhoneForm
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
            gridNameLabel = new Label();
            phonesDataGridView = new DataGridView();
            modelLabel = new Label();
            brandlabel = new Label();
            priceLabel = new Label();
            modelTextBox = new TextBox();
            brandTextBox = new TextBox();
            priceTextBox = new TextBox();
            saveButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            backButton = new Button();
            titleLabel = new Label();
            providerComboBox = new ComboBox();
            providerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)phonesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // gridNameLabel
            // 
            gridNameLabel.AutoSize = true;
            gridNameLabel.Location = new Point(654, 97);
            gridNameLabel.Name = "gridNameLabel";
            gridNameLabel.Size = new Size(82, 32);
            gridNameLabel.TabIndex = 0;
            gridNameLabel.Text = "Phone";
            // 
            // phonesDataGridView
            // 
            phonesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            phonesDataGridView.Location = new Point(654, 132);
            phonesDataGridView.Name = "phonesDataGridView";
            phonesDataGridView.RowHeadersWidth = 82;
            phonesDataGridView.Size = new Size(633, 371);
            phonesDataGridView.TabIndex = 1;
            phonesDataGridView.SelectionChanged += phonesDataGridView_SelectionChanged;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(78, 132);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(102, 32);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Modelo:";
            // 
            // brandlabel
            // 
            brandlabel.AutoSize = true;
            brandlabel.Location = new Point(78, 251);
            brandlabel.Name = "brandlabel";
            brandlabel.Size = new Size(84, 32);
            brandlabel.TabIndex = 3;
            brandlabel.Text = "Marca:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(78, 372);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(84, 32);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Precio:";
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(186, 132);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(397, 39);
            modelTextBox.TabIndex = 5;
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(186, 251);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(397, 39);
            brandTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(186, 372);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(397, 39);
            priceTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(85, 562);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 46);
            saveButton.TabIndex = 8;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(272, 562);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 9;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(465, 562);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(150, 46);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(85, 654);
            backButton.Name = "backButton";
            backButton.Size = new Size(530, 46);
            backButton.TabIndex = 11;
            backButton.Text = "Atras";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(570, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(149, 45);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "Celulares";
            // 
            // providerComboBox
            // 
            providerComboBox.FormattingEnabled = true;
            providerComboBox.Location = new Point(188, 433);
            providerComboBox.Name = "providerComboBox";
            providerComboBox.Size = new Size(395, 40);
            providerComboBox.TabIndex = 13;
            // 
            // providerLabel
            // 
            providerLabel.AutoSize = true;
            providerLabel.Location = new Point(80, 433);
            providerLabel.Name = "providerLabel";
            providerLabel.Size = new Size(123, 32);
            providerLabel.TabIndex = 14;
            providerLabel.Text = "Proveedor";
            // 
            // PhoneForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 825);
            Controls.Add(providerLabel);
            Controls.Add(providerComboBox);
            Controls.Add(titleLabel);
            Controls.Add(backButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(saveButton);
            Controls.Add(priceTextBox);
            Controls.Add(brandTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(priceLabel);
            Controls.Add(brandlabel);
            Controls.Add(modelLabel);
            Controls.Add(phonesDataGridView);
            Controls.Add(gridNameLabel);
            Name = "PhoneForm";
            Text = "PhoneForm";
            Load += PhoneForm_Load;
            ((System.ComponentModel.ISupportInitialize)phonesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gridNameLabel;
        private DataGridView phonesDataGridView;
        private Label modelLabel;
        private Label brandlabel;
        private Label priceLabel;
        private TextBox modelTextBox;
        private TextBox brandTextBox;
        private TextBox priceTextBox;
        private Button saveButton;
        private Button editButton;
        private Button deleteButton;
        private Button backButton;
        private Label titleLabel;
        private ComboBox providerComboBox;
        private Label providerLabel;
    }
}