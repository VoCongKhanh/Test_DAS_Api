namespace DAS_API.Entities
{
    public class JobItem
    {

        public int Id { get; set; }
        public int ItemNo { get; set; }
        public int JobId { get; set; }
        public Job job { get; set; }
        public string ItemCode { get; set; }
        public string? Description { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Reveal { get; set; }
        public string? Glass { get; set; }
        public string? Options { get; set; }
        public string? CustomerRef { get; set; }
        public int Quantity { get; set; }
        public string? BarCode { get; set; }
    }
}
