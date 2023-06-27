namespace StaticaDbContext.Models
{
    public partial class Session
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Cookie { get; set; } = null!;
        public DateOnly? CreationDate { get; set; }
    }
}
