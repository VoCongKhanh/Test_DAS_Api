namespace DAS_API.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public int JobNo { get; set; }
        public int TruckNo { get; set; }
        public required string CustomerName { get; set; }
        public required string CustomerContact { get; set; }
        public required string Phone { get; set; }
        public required string Mobile { get; set; }
        public required string DeliveryAddress { get; set; }
        public required string PONumber { get; set; }
        public string? SalesPerson { get; set; }
        public string? Instructions { get; set; }
        public bool KeyToSite { get; set; }
        public List<JobItem> JobItems { get; set; }
    }
}
