namespace StaticaDbContext.Models
{
    public partial class Axle
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public double? TareWeight { get; set; }
        public double? BruttoWeight { get; set; }
        public int Num { get; set; }
        public bool? IsOverweightBrutto { get; set; }

        public virtual Journal Journal { get; set; } = null!;
    }
}
