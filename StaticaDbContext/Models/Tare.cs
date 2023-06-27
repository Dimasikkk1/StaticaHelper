namespace StaticaDbContext.Models
{
    public partial class Tare
    {
        public Tare()
        {
            Goods = new HashSet<Good>();
            InverseParent = new HashSet<Tare>();
        }

        public int Id { get; set; }
        public int ParentId { get; set; }
        public string? Name { get; set; }
        public bool? Isgroup { get; set; }
        public double? TareWeight { get; set; }
        public bool? Deleted { get; set; }

        public virtual Tare Parent { get; set; } = null!;
        public virtual ICollection<Good> Goods { get; set; }
        public virtual ICollection<Tare> InverseParent { get; set; }
    }
}
