namespace StaticaDbContext.Models
{
    public partial class Log
    {
        public int Id { get; set; }
        public DateTime ActionDate { get; set; }
        public string? ActionThing { get; set; }
        public string? Value { get; set; }
        public string? OldValue { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
