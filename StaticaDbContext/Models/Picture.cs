namespace StaticaDbContext.Models
{
    public partial class Picture
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public byte[] Photo { get; set; } = null!;

        public virtual Journal Journal { get; set; } = null!;
    }
}
