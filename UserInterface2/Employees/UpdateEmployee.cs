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
    public partial class UpdateEmployee : Form
    {
        UserInterface Form = new UserInterface();

        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if (Form.ValidateNulls(uxFirstNameText.Text, "First Name") && Form.ValidateNulls(uxLastNameText.Text, "Last Name") && Form.ValidateNulls(uxDateofBirthText.Text, "Date of Birth") && Form.ValidateNulls(uxTitleText.Text, "Title") &&
               Form.ValidateNulls(uxDateofHireText.Text, "Address") && Form.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status") && Form.ValidateNulls(uxHourlyRateText.Text, "Hourly Rate") &&
               Form.ValidateNulls(uxEmployeeSearch.Text, "Select Employee"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
