namespace StaticaDbContext.Models
{
    public partial class Downsusp
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public int Num { get; set; }
        public short Down { get; set; }
        public short Susp { get; set; }

        public virtual Journal Journal { get; set; } = null!;
    }
}
