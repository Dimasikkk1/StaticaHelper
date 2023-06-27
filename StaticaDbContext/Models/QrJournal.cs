namespace StaticaDbContext.Models
{
    public partial class QrJournal
    {
        public int Id { get; set; }
        public int? JournalId { get; set; }
        public DateTime? WeighDate { get; set; }
        public string? Truck { get; set; }
        public string? Trailer { get; set; }
        public string? Good { get; set; }
        public string? Recipient { get; set; }
        public double? Weight1 { get; set; }
        public double? Weight2 { get; set; }
        public double? Netto { get; set; }
        public string? Operator { get; set; }

        public virtual Journal? Journal { get; set; }
    }
}
