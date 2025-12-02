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
        UserInterface Form = new UserInterface();

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
            if(Form.ValidateNulls(uxProjectIDText.Text, "ProjectID") && Form.ValidateNulls(uxEmployeeIDText.Text, "EmployeeID") && Form.ValidateNulls(uxDateText.Text, "Date") && Form.ValidateNulls(uxHoursText.Text, "Hours") && Form.ValidateNulls(uxDescriptionText.Text, "Description"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
