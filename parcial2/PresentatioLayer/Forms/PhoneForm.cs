using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using FluentValidation;
using System;
using System.Windows.Forms;

namespace PresentatioLayer.Forms
{
    public partial class PhoneForm : Form
    {
        private PhoneRepository _phoneRepository;
        private PhoneValidator _phoneValidator;

        public PhoneForm()
        {
            InitializeComponent();
            _phoneRepository = new PhoneRepository();
            _phoneValidator = new PhoneValidator();
            LoadPhones();
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void LoadPhones()
        {
            phonesDataGridView.DataSource = _phoneRepository.GetPhones();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var phone = new Phone
            {
                Model = modelTextBox.Text,
                Brand = brandTextBox.Text,
                Price = decimal.Parse(priceTextBox.Text),
                ProviderID = (int)providerComboBox.SelectedValue 
            };

            var validationResult = _phoneValidator.Validate(phone);
            if (!validationResult.IsValid)
            {
                MessageBox.Show(validationResult.Errors[0].ErrorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _phoneRepository.AddPhone(phone);
            LoadPhones();
            ClearFields();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (phonesDataGridView.SelectedRows.Count == 0) return;

            var selectedRow = phonesDataGridView.SelectedRows[0];
            var phoneID = (int)selectedRow.Cells["PhoneID"].Value;

            var phone = new Phone
            {
                PhoneID = phoneID,
                Model = modelTextBox.Text,
                Brand = brandTextBox.Text,
                Price = decimal.Parse(priceTextBox.Text)
            };

            var validator = new PhoneValidator();
            var result = validator.Validate(phone);
            if (!result.IsValid)
            {
                MessageBox.Show(string.Join(Environment.NewLine, result.Errors));
                return;
            }

            _phoneRepository.EditPhone(phone);
            LoadPhones();
            ClearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (phonesDataGridView.SelectedRows.Count == 0) return;

            var selectedRow = phonesDataGridView.SelectedRows[0];
            var phoneID = (int)selectedRow.Cells["PhoneID"].Value;

            _phoneRepository.DeletePhone(phoneID);
            LoadPhones();
        }

        private void phonesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (phonesDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = phonesDataGridView.SelectedRows[0];
                brandTextBox.Text = selectedRow.Cells["Brand"].Value.ToString();
                modelTextBox.Text = selectedRow.Cells["Model"].Value.ToString();
                priceTextBox.Text = selectedRow.Cells["Price"].Value.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var providerForm = new ProviderForm();
            providerForm.Show();
        }

        private void ClearFields()
        {
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();
        }
    }
}
