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
using ProjectData.Models;

namespace UserInterface2
{
    public partial class AddProposal : Form
    {
        private readonly SqlProjectProposalRepository _proposalRepo;

        public AddProposal(SqlProjectProposalRepository repo)
        {
            InitializeComponent();
            _proposalRepo = repo;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxOK_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateNulls(uxProjectNameText.Text, "Project Name") && Validation.ValidateNulls(uxProjectDetailsText.Text, "Project Details") && Validation.ValidateNulls(uxCustomerIDText.Text, "CustomerID") &&
                Validation.ValidateNulls(uxEstimatedDurationHoursText.Text, "Estimated Duration Hours") && Validation.CheckCheckBoxes(checkBox1.Checked, checkBox2.Checked, "Status"))
            {
                _proposalRepo.CreateProposal(uxProjectNameText.Text, uxProjectDetailsText.Text, int.Parse(uxCustomerIDText.Text),
                    int.Parse(uxEstimatedDurationHoursText.Text), GetCheckBoxStatus(checkBox1.Checked, checkBox2.Checked));

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private ProposalStatus GetCheckBoxStatus(bool isActivated, bool inactive)
        {
            if(isActivated && !inactive)
            {
                return ProposalStatus.Approved;
            }
            else { return ProposalStatus.Declined; }
        }
    }
}
