namespace StaticaDbContext.Models
{
    public partial class PepsiRecord
    {
        public int Id { get; set; }
        public int? JournalId { get; set; }
        public int WeightStatus { get; set; }
        public string? QrResult { get; set; }
        public string? TrResult { get; set; }
        public string TrackNum { get; set; } = null!;
        public string TruckNum { get; set; } = null!;

        public virtual Journal? Journal { get; set; }
    }
}
