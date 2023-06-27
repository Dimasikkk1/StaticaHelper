namespace StaticaDbContext.Models
{
    public partial class BadTransaction
    {
        public int Id { get; set; }
        public DateTime WeighDate { get; set; }
        public string Rfid { get; set; } = null!;
        public string? Plate { get; set; }
        public double Weight { get; set; }
        public byte[]? Photo1 { get; set; }
        public byte[]? Photo2 { get; set; }
        public byte[]? Photo3 { get; set; }
        public byte[]? Photo4 { get; set; }
        public string? RfidId { get; set; }
    }
}
