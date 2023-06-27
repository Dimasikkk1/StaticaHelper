namespace StaticaDbContext.Models
{
    /// <summary>
    /// Вагоны
    /// </summary>
    public partial class Train
    {
        public Train()
        {
            InverseParent = new HashSet<Train>();
            Journals = new HashSet<Journal>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public bool? Isgroup { get; set; }
        public string? Type { get; set; }
        public bool Deleted { get; set; }
        public double Tara { get; set; }
        public double AvailableMass { get; set; }

        public virtual Train? Parent { get; set; }
        public virtual ICollection<Train> InverseParent { get; set; }
        public virtual ICollection<Journal> Journals { get; set; }
    }
}
