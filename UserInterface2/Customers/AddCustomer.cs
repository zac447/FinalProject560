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
    public partial class AddCustomer : Form
    {
        private UserInterface Form = new UserInterface();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if(Form.ValidateNulls(uxEmailText.Text, "Email") && Form.ValidateNulls(uxFirstNameText.Text, "First Name") && Form.ValidateNulls(uxLastNameText.Text, "Last Name") && Form.ValidateNulls(uxPhoneText.Text, "Phone Number") &&
               Form.ValidateNulls(uxAddressText.Text, "Address") && Form.ValidateNulls(uxCityText.Text, "City") && Form.ValidateNulls(uxStateText.Text, "State") && Form.ValidateNulls(uxZipCodeText.Text, "Zip Code") &&
               Form.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
