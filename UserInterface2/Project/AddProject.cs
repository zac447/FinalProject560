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
    public partial class AddProject : Form
    {
        private readonly SqlProjectRepository _repo;

        public AddProject(SqlProjectRepository repo)
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
            if(Validation.ValidateNulls(uxManagerIDText.Text, "ManagerID") && Validation.ValidateNulls(uxStartDateText.Text, "Start Date") && Validation.ValidateNulls(uxPropsalIDText.Text, "ProposalID") &&
                Validation.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                _repo.CreateProject(int.Parse(uxPropsalIDText.Text), int.Parse(uxManagerIDText.Text), DateTime.Parse(uxStartDateText.Text),
                    checkBox1.Checked || checkBox2.Checked ? ProjectData.Models.ProjectStatus.NotStarted : ProjectData.Models.ProjectStatus.Completed);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
