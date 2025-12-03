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
    public partial class LogHours : Form
    {
        

        public LogHours()
        {
            InitializeComponent();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if(Validation.ValidateNulls(uxProjectIDText.Text, "ProjectID") && Validation.ValidateNulls(uxEmployeeIDText.Text, "EmployeeID") && Validation.ValidateNulls(uxDateText.Text, "Date") && Validation.ValidateNulls(uxHoursText.Text, "Hours") && Validation.ValidateNulls(uxDescriptionText.Text, "Description"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
