namespace StaticaDbContext.Models
{
    /// <summary>
    /// Прицепы
    /// </summary>
    public partial class Trailer
    {
        public Trailer()
        {
            BetweenTrailers = new HashSet<BetweenTrailer>();
            Cars = new HashSet<Car>();
            DownSuspTrailers = new HashSet<DownSuspTrailer>();
            InverseParent = new HashSet<Trailer>();
            Journals = new HashSet<Journal>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public bool? Isgroup { get; set; }
        public string? Mark { get; set; }
        public string? Model { get; set; }
        public string? Type { get; set; }
        public bool Deleted { get; set; }

        public virtual Trailer? Parent { get; set; }
        public virtual ICollection<BetweenTrailer> BetweenTrailers { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<DownSuspTrailer> DownSuspTrailers { get; set; }
        public virtual ICollection<Trailer> InverseParent { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
