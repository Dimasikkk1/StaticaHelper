namespace StaticaDbContext.Models
{
    public partial class LukoilTable
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public DateTime WeightDate { get; set; }
        public double? Tare { get; set; }
        public double? Brutto { get; set; }
        public double? Netto { get; set; }
        public double? Oiled { get; set; }
        public string? GosNum { get; set; }
    }
}
