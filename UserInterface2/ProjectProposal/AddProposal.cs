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
    public partial class AddProposal : Form
    {
        private UserInterface Form = new UserInterface();

        public AddProposal()
        {
            InitializeComponent();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if (Form.ValidateNulls(uxProjectNameText.Text, "Project Name") && Form.ValidateNulls(uxProjectDetailsText.Text, "Project Details") && Form.ValidateNulls(uxCustomerIDText.Text, "CustomerID") &&
                Form.ValidateNulls(uxEstimatedDurationHoursText.Text, "Estimated Duration Hours") && Form.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            //if(Form.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            //{
            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}


        }
    }
}
