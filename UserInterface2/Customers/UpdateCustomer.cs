using ProjectData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface2
{
    public partial class UpdateCustomer : Form
    {
        private readonly SqlCustomerRepository _repo;

        public UpdateCustomer(SqlCustomerRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateNulls(uxEmailText.Text, "Email") && Validation.ValidateNulls(uxFirstNameText.Text, "First Name") && Validation.ValidateNulls(uxLastNameText.Text, "Last Name") && Validation.ValidateNulls(uxPhoneText.Text, "Phone Number") &&
               Validation.ValidateNulls(uxAddressText.Text, "Address") && Validation.ValidateNulls(uxCityText.Text, "City") && Validation.ValidateNulls(uxStateText.Text, "State") && Validation.ValidateNulls(uxZipCodeText.Text, "Zip Code") &&
               Validation.ValidateNulls(uxCustomerSearch.Text, "Select Customer") && Validation.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                _repo.UpdateCustomer(int.Parse(uxCustomerSearch.Text), uxEmailText.Text, uxLastNameText.Text, uxFirstNameText.Text, uxPhoneText.Text,
                    uxAddressText.Text, uxCityText.Text, uxStateText.Text, uxZipCodeText.Text,
                    checkBox1.Checked || checkBox2.Checked ? ProjectData.Models.CustomerStatus.Active : ProjectData.Models.CustomerStatus.Inactive);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
