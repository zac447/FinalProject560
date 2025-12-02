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
    public partial class AddProject : Form
    {
        private UserInterface Form = new UserInterface();

        public AddProject()
        {
            InitializeComponent();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if(Form.ValidateNulls(uxCustomerIDText.Text, "CustomerID") && Form.ValidateNulls(uxManagerIDText.Text, "ManagerID") && Form.ValidateNulls(uxProjectProposalIDText.Text, "ProjectProposalID") && 
                Form.ValidateNulls(uxStartDateText.Text, "StartDate") && Form.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
