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
    public partial class TotalHoursPerProject : Form
    {
        public int ProjectID { get; private set; }
        public TotalHoursPerProject()
        {
            InitializeComponent();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if(int.TryParse(uxSelectedProject.Text, out int id))
            {
                ProjectID = id;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
