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
    public partial class UpdateProjectStatus : Form
    {
        UserInterface Form = new UserInterface();

        public UpdateProjectStatus()
        {
            InitializeComponent();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if(Form.ValidateNulls(uxProjectSearch.Text, "Select Project") && Form.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
