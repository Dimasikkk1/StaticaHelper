namespace StaticaDbContext.Models
{
    public partial class LukoilTableMethodNew
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public string TicketId { get; set; } = null!;
        public DateTime? WeightDate { get; set; }
        public string? TruckNumSuo { get; set; }
        public string? TrailerNumSuo { get; set; }
        public string? TruckNum { get; set; }
        public string? TrailerNum { get; set; }
        public double? Tare { get; set; }
        public double? Brutto { get; set; }
        public double? Netto { get; set; }
        public double? Oiled { get; set; }
        public bool WasReverse { get; set; }
        public string? ScalesId { get; set; }
    }
}
