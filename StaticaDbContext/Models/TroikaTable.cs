namespace StaticaDbContext.Models
{
    public partial class TroikaTable
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public DateTime TareDate { get; set; }
        public DateTime BruttoDate { get; set; }
        public int Tare { get; set; }
        public int Brutto { get; set; }
        public string? GosNum { get; set; }
    }
}
