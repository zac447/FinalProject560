using ProjectData;
using ProjectData.Models;
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
    public partial class UpdateProposalStatus : Form
    {
        private readonly SqlProjectProposalRepository _repo;

        public UpdateProposalStatus(SqlProjectProposalRepository repo)
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
            if(Validation.ValidateNulls(uxProposalSearch.Text, "Select Proposal") && Validation.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                _repo.UpdateProposalStatus(int.Parse(uxProposalSearch.Text), GetCheckBoxStatus(checkBox1.Checked, checkBox2.Checked));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private ProposalStatus GetCheckBoxStatus(bool isActivated, bool inactive)
        {
            if (isActivated && !inactive)
            {
                return ProposalStatus.Approved;
            }
            else { return ProposalStatus.Declined; }
        }
    }
}
