namespace StaticaDbContext.Models
{
    public partial class JournalApiSend
    {
        public int Id { get; set; }
        public int JournalId { get; set; }

        public virtual Journal Journal { get; set; } = null!;
    }
}
