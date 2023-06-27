namespace StaticaDbContext.Models
{
    public partial class BetweenTrailer
    {
        public int Id { get; set; }
        public int TrailerId { get; set; }
        public int Betw { get; set; }

        public virtual Trailer Trailer { get; set; } = null!;
    }
}
