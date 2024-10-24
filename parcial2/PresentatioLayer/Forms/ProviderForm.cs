using BusinessLayer.services;
using CommonLayer.Entities;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Windows.Forms;
using Validation;

namespace PresentatioLayer.Forms
{
    public partial class ProviderForm : Form
    {
        private ProviderService _providerService;
        private ProviderValidator _providerValidator;

        public ProviderForm()
        {
            InitializeComponent();
            _providerService = new ProviderService();
            _providerValidator = new ProviderValidator();
            LoadProviders();
            LoadProvidersIntoComboBox();
        }

        private void LoadProviders()
        {
            providerDataGridView.DataSource = _providerService.GetAllProviders();
        }

        private void LoadProvidersIntoComboBox()
        {
            var providers = _providerService.GetAllProviders();
            phoneComboBox.DataSource = providers;
            phoneComboBox.DisplayMember = "Name";
            phoneComboBox.ValueMember = "ProviderID";
        }

        private void providerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (providerDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = providerDataGridView.SelectedRows[0];
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                phoneComboBox.Text = selectedRow.Cells["Phone"].Value.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
            }
            else
            {
                ClearFields();
            }
        }

        private void ClearFields()
        {
            nameTextBox.Clear();
            phoneComboBox.SelectedIndex = -1;
            emailTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var provider = new Provider
            {
                Name = nameTextBox.Text,
                Phone = phoneComboBox.Text,
                Email = emailTextBox.Text
            };

            ValidationResult result = _providerValidator.Validate(provider);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result.Errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _providerService.AddProvider(provider);
            MessageBox.Show("agregado correctamente");
            LoadProviders();
            ClearFields();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (providerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("selecciona para editar");
                return;
            }

            var selectedRow = providerDataGridView.SelectedRows[0];
            var providerID = Convert.ToInt32(selectedRow.Cells["ProviderID"].Value);

            var provider = new Provider
            {
                ProviderID = providerID,
                Name = nameTextBox.Text,
                Phone = phoneComboBox.Text,
                Email = emailTextBox.Text
            };

            ValidationResult result = _providerValidator.Validate(provider);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result.Errors), "Validation Errors", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _providerService.UpdateProvider(provider);
            MessageBox.Show("actualizado correctamente.");
            LoadProviders();
            ClearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (providerDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("por favor elija un proovedor.");
                return;
            }

            var selectedRow = providerDataGridView.SelectedRows[0];
            var providerID = Convert.ToInt32(selectedRow.Cells["ProviderID"].Value);

            DialogResult confirmation = MessageBox.Show("estas sefuro de esta accion", "confirma accion", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                _providerService.DeleteProvider(providerID);
                MessageBox.Show("se elimino correctamente");
                LoadProviders();
                ClearFields();
            }
        }

        private void phoneButton_Click(object sender, EventArgs e)
        {
            PhoneForm phoneForm = new PhoneForm();
            phoneForm.Show();
            this.Hide();
        }
    }
}
