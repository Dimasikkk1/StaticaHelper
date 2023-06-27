namespace StaticaDbContext.Models
{
    public partial class Vel
    {
        public int Id { get; set; }
        public int JournalId { get; set; }
        public double Vel1 { get; set; }
        public double Vel2 { get; set; }
        public int Num { get; set; }

        public virtual Journal Journal { get; set; } = null!;
    }
}
