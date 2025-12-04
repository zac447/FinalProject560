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
    public partial class MonthlySalesByEmployeeForm : Form
    {
        public DateTime Start { get; private set; }

        public DateTime End { get; private set; }

        public MonthlySalesByEmployeeForm()
        {
            InitializeComponent();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if(!DateTime.TryParse(uxStartText.Text, out DateTime start))
            {
                MessageBox.Show("Invalid start date.");
                return;
            }
            if(!DateTime.TryParse(uxEndText.Text, out DateTime end))
            {
                MessageBox.Show("Invalid end date.");
                return;
            }
            Start = start;
            End = end;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
