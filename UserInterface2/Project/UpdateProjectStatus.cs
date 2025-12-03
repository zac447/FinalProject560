using ProjectData;
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
        private readonly SqlProjectRepository _repo;

        public UpdateProjectStatus(SqlProjectRepository repo)
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
            if(Validation.ValidateNulls(uxProjectSearch.Text, "Select Project") && Validation.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                _repo.UpdateProjectStatus(int.Parse(uxProjectSearch.Text), checkBox1.Checked || checkBox2.Checked ? ProjectData.Models.ProjectStatus.NotStarted : ProjectData.Models.ProjectStatus.Completed);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
