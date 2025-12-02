namespace ProjectData.Models
{
    public class ProjectProposal
    {
        public int ProjectProposalId { get; }
        public string ProjectName { get; }
        public string ProjectDetails { get; }
        public int CustomerId { get; }
        public int EstimatedDurationHours { get; }
        public ProposalStatus Status { get; }

        internal ProjectProposal(int projectProposalId, string projectName, string projectDetails,
           int customerId, int estimatedDurationHours, ProposalStatus status)
        {
            ProjectProposalId = projectProposalId;
            ProjectName = projectName;
            ProjectDetails = projectDetails;
            CustomerId = customerId;
            EstimatedDurationHours = estimatedDurationHours;
            Status = status;
        }
    }
}