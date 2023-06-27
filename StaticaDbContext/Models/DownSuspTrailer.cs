namespace StaticaDbContext.Models
{
    public partial class DownSuspTrailer
    {
        public int Id { get; set; }
        public int TrailerId { get; set; }
        public short Down { get; set; }
        public short Susp { get; set; }

        public virtual Trailer Trailer { get; set; } = null!;
    }
}
