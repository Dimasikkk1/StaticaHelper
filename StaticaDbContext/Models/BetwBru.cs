namespace StaticaDbContext.Models
{
    public partial class BetwBru
    {
        public int Id { get; set; }
        public int? JournalId { get; set; }
        public int? BetVal { get; set; }
        public int? Num { get; set; }

        public virtual Journal? Journal { get; set; }
    }
}
