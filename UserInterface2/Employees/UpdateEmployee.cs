using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectData;

namespace UserInterface2
{
    public partial class UpdateEmployee : Form
    {
        private readonly SqlEmployeeRepository _repo;

        public UpdateEmployee(SqlEmployeeRepository repo)
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
            if (Validation.ValidateNulls(uxFirstNameText.Text, "First Name") && Validation.ValidateNulls(uxLastNameText.Text, "Last Name") && Validation.ValidateNulls(uxDateofBirthText.Text, "Date of Birth") && Validation.ValidateNulls(uxTitleText.Text, "Title") &&
               Validation.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status") && Validation.ValidateNulls(uxHourlyRateText.Text, "Hourly Rate") &&
               Validation.ValidateNulls(uxEmployeeSearch.Text, "Select Employee"))
            {
                _repo.UpdateEmployee(int.Parse(uxEmployeeSearch.Text), 
                    string.IsNullOrWhiteSpace(uxManagerIDText.Text) ? (int?)null : int.Parse(uxManagerIDText.Text),
                    uxLastNameText.Text,
                    uxFirstNameText.Text,  
                    DateTime.Parse(uxDateofBirthText.Text), 
                    uxTitleText.Text,
                    checkBox1.Checked || checkBox2.Checked ? ProjectData.Models.EmployeeStatus.Active : ProjectData.Models.EmployeeStatus.Inactive,
                    decimal.Parse(uxHourlyRateText.Text));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
