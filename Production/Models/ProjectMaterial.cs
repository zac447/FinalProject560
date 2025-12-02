namespace ProjectData.Models
{
    public class ProjectMaterial
    {
        public int MaterialId { get; }
        public int ProjectId { get; }
        public string Description { get; }
        public int Quantity { get; }
        public decimal Total { get; }

        internal ProjectMaterial(int materialId, int projectId, string description,
           int quantity, decimal total)
        {
            MaterialId = materialId;
            ProjectId = projectId;
            Description = description;
            Quantity = quantity;
            Total = total;
        }
    }
}