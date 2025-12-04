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
    public partial class ProjectMaterialCost : Form
    {
        public int ProjectID { get; private set; }

        public string Status { get; private set; }

        public ProjectMaterialCost()
        {
            InitializeComponent();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if (int.TryParse(uxSelectedProject.Text, out int id))
            {
                ProjectID = id;
            }
            if (checkBox1.Checked)
            {
                Status = "NotStarted";
            }
            else if (checkBox2.Checked)
            {
                Status = "Completed";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
